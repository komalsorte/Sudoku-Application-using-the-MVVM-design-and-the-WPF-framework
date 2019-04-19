//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Sudoku.Model;

///// <summary>
///// Author: Komal Sorte
///// Project 2 Phase 1 : Generate Sudoku puzzle using backtracking.
///// </summary>
///// 
//namespace Sudoku.View
//{
//    /// <summary>
//    /// View consisting of all the UI logic for displaying the genarted Sudoku solution 
//    /// for 4x4 or 9x9 puzzle with varying difficulty - easy, medium or hard. 
//    /// </summary>
//    class SudokuView
//    {
//        /// <summary>
//        /// Parameterized Constructed
//        /// initializes the event with its display method.
//        /// </summary>
//        /// <param name="puzzleModel"> instance of the model </param>
//        public SudokuView(SudokuModel puzzleModel)
//        {
//            puzzleModel.GeneratePuzzleEvent += displaySudokuSolution;
//        }

//        /// <summary>
//        /// Displays the generated sudoku puzzle.
//        /// Contains UI logic
//        /// It is triggered by the event GeneratePuzzleEvent from the model.
//        /// </summary>
//        /// <param name="puzzleModel"> instance of the model </param>
//        private void displaySudokuSolution(SudokuModel puzzleModel, String msg)
//        {
//            Console.WriteLine(msg);
//            Console.WriteLine("Difficulty Level: " + puzzleModel.BoardDifficulty);
//            Console.WriteLine("\n\n__________________________________________\n\n\n");
//            int limit = 0;
//            if (puzzleModel.BoardRows == 9)
//                limit = 3;
//            else
//                limit = 2;

//            string line;
//            if (limit == 2)
//                line = "----------+----------";
//            else
//                line = "-------------+-----------+-------------";
//            for (int i = 0; i < puzzleModel.BoardRows; i++)
//            {
//                if (i % limit == 0 || i == 0)
//                    Console.WriteLine(line);

//                for (int j = 0; j < puzzleModel.BoardCols; j++)
//                {
//                    if (j % limit == 0 || j == 0)
//                        Console.Write(" | ");

//                    Console.Write(" " + puzzleModel.PuzzleBoard[i, j] + " ");

//                    if (j == puzzleModel.BoardCols - 1)
//                        Console.Write(" | ");
//                    if ((i == puzzleModel.BoardRows - 1) && (j == puzzleModel.BoardCols - 1))
//                        Console.WriteLine("\n" + line);
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("\n\n__________________________________________\n\n");
//        }

//        //static void Main(string[] args)
//        //{
//        //    SudokuModel puzzleModel = new SudokuModel(args[0], args[1]);
//        //    new SudokuView(puzzleModel);

//        //    puzzleModel.GenerateSudokuPuzzle();

//        //    if (Debugger.IsAttached)
//        //    {
//        //        Console.WriteLine("Press any key to continue . . .");
//        //        Console.ReadLine();
//        //    }
//        //}
//    }
//}
