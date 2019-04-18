using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Komal Sorte
/// Project 2 Phase 1 : Generate Sudoku puzzle using backtracking, pruning.
/// </summary>
/// 

namespace Sudoku.Model
{
    /// <summary>
    /// Model consisting of all the business logic for generating Sudoku solution 
    /// for 4x4 or 9x9 puzzle with varying difficulty - easy, medium or hard. 
    /// </summary>
    class SudokuModel
    {
        private static int[,] board;
        private const int DEFAULT = 0;
        private static int boardRows;
        private static int boardCols;
        private static string difficulty;
        private static int[,] boardSol;

        public delegate void PuzzleGeneratorHandler(SudokuModel puzzle, String msg);

        public event PuzzleGeneratorHandler GeneratePuzzleEvent;

        public static int[,] Board => board;

        public int BoardRows
        {
            get => boardRows;
            private set => boardRows = value;
        }

        public int BoardCols
        {
            get => boardCols;
            private set => boardCols = value;
        }

        public string BoardDifficulty
        {
            get => difficulty;
            private set => difficulty = value;
        }

        public int[,] PuzzleBoard => board;

        public SudokuModel(string size, string difficulty)
        {
            SanityCheck(Int32.Parse(size), difficulty);
            init(Int32.Parse(size), difficulty);

        }

        /// <summary>
        /// Checks if supplied arguments i.e. the size and difficulty level 
        /// of the puzzle board are valid. Else throws an InvalidArgumentException
        /// </summary>
        /// <param name="size"> Size of each row and column for the puzzle board</param>
        /// <param name="difficulty"> Difficulty level of the puzzle</param>
        private void SanityCheck(int size, string difficulty)
        {
            if (!(size.Equals(9) || size.Equals(4)))
                throw new InvalidArgumentException<int>(size);

            if (!(difficulty.Equals("easy", StringComparison.OrdinalIgnoreCase) ||
                difficulty.Equals("medium", StringComparison.OrdinalIgnoreCase) ||
                difficulty.Equals("hard", StringComparison.OrdinalIgnoreCase)))
                throw new InvalidArgumentException<string>(difficulty);
        }

        /// <summary>
        /// Initializes the puzzle board
        /// </summary>
        /// <param name="size"> Size of each row and column for the puzzle board</param>
        /// <param name="difficulty"> Difficulty level of the puzzle</param>
        private void init(int size, string difficulty)
        {
            BoardDifficulty = difficulty;
            BoardCols = size;
            BoardRows = size;
            board = new int[boardRows, boardCols];
            boardSol = new int[boardRows, boardCols];
        }

        /// <summary>
        /// Triggers generation of sudoku solution
        /// Once a solution is generated it triggers a function which randomly selects spaces 
        /// based on difficulty level and sets them to DEFAULT.
        /// Displays final puzzle to user via firing the event GeneratePuzzleEvent.
        /// </summary>
        public void GenerateSudokuPuzzle()
        {
            bool success = false;
            int[,] boardTemp = new int[BoardRows, BoardCols];
            //string msg;
            generateSolution();
            //msg = "Generating " + boardRows + " X " + boardCols + " Sudoku Solution...";
            //GeneratePuzzleEvent?.Invoke(this, msg);


            //Storing solution
            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardCols; col++)
                {
                    boardSol[row, col] = board[row, col];
                }
            }

            int count = 1;
            do
            {
                //generating puzzle
                setDifficultyOnSolution();
                //msg = "Generated " + boardRows + " X " + boardCols + " Sudoku Puzzle...";
                //GeneratePuzzleEvent?.Invoke(this, msg);

                //Storing puzzle 
                for (int row = 0; row < BoardRows; row++)
                {
                    for (int col = 0; col < BoardCols; col++)
                    {
                        boardTemp[row, col] = board[row, col];
                    }
                }

                //passing the puzzle to function to validate if the new solution matches the original solution
                //msg = "Validating " + boardRows + " X " + boardCols + " Sudoku Puzzle...";
                validateSolution();

                if (isEqual(boardSol))
                {
                    //GeneratePuzzleEvent?.Invoke(this, msg + count);
                    success = true;

                    //Checks: To be removed
                    Console.WriteLine(isEqual(boardSol));
                    Console.WriteLine(isEqual(boardSol));
                    Console.WriteLine(isEqual(boardSol));

                    board = boardTemp;
                    //msg = "Generated " + boardRows + " X " + boardCols + " Sudoku Puzzle...";
                    //GeneratePuzzleEvent?.Invoke(this, msg);

                }
                else
                {
                    count++;
                    for (int row = 0; row < BoardRows; row++)
                    {
                        for (int col = 0; col < BoardCols; col++)
                        {
                            board[row, col] = boardSol[row, col];
                        }
                    }
                }

            } while (!success);

        }

        private bool isEqual(int[,] boardSol)
        {
            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardCols; col++)
                {
                    if (board[row, col] != boardSol[row, col])
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Generates a solution for soduku puzzle using backtracking.
        /// </summary>
        /// <returns>true if solution is generated successfully</returns>
        private bool generateSolution()
        {
            Random rand = new Random();
            bool flag, flagNegative = false; ;
            int number;
            int[] possibleNumbers;

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardCols; col++)
                {
                    if (board[row, col] == DEFAULT)
                    {
                        for (int num = 1; num <= boardRows; num++)
                        {
                            int countNegative = boardRows;
                            /// array of possible numbers for each cell
                            possibleNumbers = boardRows == 9 ? (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })
                                : (new int[] { 1, 2, 3, 4 });

                            if (!(board[row, col] == DEFAULT))
                            {
                                /// Above the array has been reset as the cell exhausted all of its options.
                                /// below lines of code is executed while backtracing.
                                /// This ensures that current number for the current cell is not repeated again 
                                /// and its chooses the value later only from rest of its options.
                                /// Hence, it is found and set to its negative value in the array.
                                /// possibleNumbers[] - consists of all possible numbers for the given cell.
                                for (int i = 0; i < possibleNumbers.Length; i++)
                                {
                                    if (board[row, col] == possibleNumbers[i])
                                    {
                                        possibleNumbers[i] = possibleNumbers[i] * -1;
                                        break;

                                    }
                                }
                            }
                            do
                            {
                                number = rand.Next(boardRows) + 1;
                                flag = !(CheckInRow(row, number) || CheckInCol(col, number) || CheckInBlock(row, col, number));
                                for (int i = 0; i < possibleNumbers.Length; i++)
                                {
                                    /// this ensures that number once chosen for a cell is not repeated again.
                                    /// Hence, the random number generated above is found and set to its negative value in the array.
                                    /// possibleNumbers[] - consists of all possible numbers for the given cell.
                                    if (number == possibleNumbers[i])
                                    {
                                        possibleNumbers[i] = possibleNumbers[i] * -1;
                                        countNegative -= 1;
                                        if (countNegative == 0)
                                            flagNegative = true;
                                        break;
                                    }
                                }
                            } while (!((flag == true && flagNegative == false) ||
                            (flag == true && flagNegative == true) ||
                            (flag == false && flagNegative == true)));

                            if (flag)
                            {
                                board[row, col] = number;
                                if (generateSolution())
                                    return true;
                                else
                                    board[row, col] = DEFAULT;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Sets difficulty level on generated solution.
        /// Calculates number of blank spaces based on difficulty level. 
        /// Easy - 40% blank spaces
        /// Medium - 55% blank spaces
        /// Hard - 75% blank spaces
        /// </summary>
        private void setDifficultyOnSolution()
        {
            int blankSpaces = 0;
            if (BoardDifficulty.Equals("easy", StringComparison.OrdinalIgnoreCase))
                blankSpaces = Convert.ToInt32(0.40 * boardRows * boardCols);
            else if (BoardDifficulty.Equals("medium", StringComparison.OrdinalIgnoreCase))
                blankSpaces = Convert.ToInt32(0.55 * boardRows * boardCols);
            else if (BoardDifficulty.Equals("hard", StringComparison.OrdinalIgnoreCase))
                blankSpaces = Convert.ToInt32(0.75 * boardRows * boardCols);
            else
                Console.WriteLine("Invalid difficulty type");

            ReplaceCellsWithSpaces(blankSpaces);
        }

        /// <summary>
        /// Replaces numbers on the board with blank spaces(DEFAULT i.e. 0) 
        /// Easy - 40% blank spaces
        /// Medium - 55% blank spaces
        /// Hard - 75% blank spaces
        /// </summary>
        private void ReplaceCellsWithSpaces(int blankSpaces)
        {
            Random rand = new Random();
            while (blankSpaces != 0)
            {
                int randomRow = rand.Next(BoardRows);
                int randomCol = rand.Next(BoardCols);
                if (board[randomRow, randomCol] != DEFAULT)
                {
                    board[randomRow, randomCol] = DEFAULT;
                    blankSpaces -= 1;
                }
            }
        }

        /// <summary>
        /// Checks if given number exists in the same row
        /// </summary>
        /// <param name="row"> row number</param>
        /// <param name="number"> number to check</param>
        /// <returns>true if number exists else false</returns>
        private bool CheckInRow(int row, int number)
        {
            for (int i = 0; i < boardRows; i++)
                if (board[row, i] == number)
                    return true;
            return false;
        }

        /// <summary>
        /// Checks if given number exists in the same column
        /// </summary>
        /// <param name="col"> column number</param>
        /// <param name="number"> number to check</param>
        /// <returns>true if number exists else false</returns>
        private bool CheckInCol(int col, int number)
        {
            for (int i = 0; i < boardCols; i++)
                if (board[i, col] == number)
                    return true;
            return false;
        }

        /// <summary>
        /// Checks if given number exists in the block where board[row,col] exists
        /// </summary>
        /// <param name="row"> row number</param>
        /// <param name="col"> column number</param>
        /// <param name="number"> number to check</param>
        /// <returns>true if number exists else false</returns>
        private bool CheckInBlock(int row, int col, int number)
        {
            int limit = 0;
            if (boardRows == 9)
                limit = 3;
            else
                limit = 2;
            int r = row - row % limit;
            int c = col - col % limit;
            for (int i = r; i < r + limit; i++)
                for (int j = c; j < c + limit; j++)
                    if (board[i, j] == number)
                        return true;
            return false;
        }

        private bool validateSolution()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == DEFAULT)
                    {
                        for (int number = 1; number <= 9; number++)
                        {
                            bool flag = !(CheckInRow(row, number) || CheckInCol(col, number) || CheckInBlock(row, col, number));
                            if (flag)
                            {
                                board[row, col] = number;
                                if (validateSolution())
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row, col] = DEFAULT;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
    }

    /// <summary>
    /// An exception used to indicate a problem that an invalid argument was entered
    /// This exception is thrown if one of the following condition occurs:
    /// if size is not 9 or not 4
    /// or if the string indicating difficulty level is not case insensitive
    /// - easy, medium or hard
    /// </summary>
    public class InvalidArgumentException<arg> : Exception
    {
        public arg BadKey { get; private set; }

        /// <summary>
        /// Create a new instance and save the argument that
        /// caused the problem.
        /// </summary>
        /// <param name="k">
        /// The argument that was entered invalid
        /// </param>
        public InvalidArgumentException(arg k) :
            base("Invalid argument entered: " + k)
        {
            BadKey = k;
        }

    }
}
