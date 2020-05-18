# Sudoku application using the MVVM design and the WPF framework

An application with a 3-tier model i.e. MVVM (Observable, Mediator, Singleton design patterns) that can generate Sudoku puzzles of varying difficulty using backtracking.\
Project has been divided into two phases:\
o Phase 1: Generate solutions for 4x4 or 9x9 puzzles.\
o Phase 2: Generate puzzles for solutions from Phase 1 that the end user could solve.

Utilized Technologies/Software: .net framework 4.7, C#, Visual Studio 2017, XAML, WPF Framework

# Design
Sudoku puzzles are logic puzzles typically on a 9x9 grid, where the objective is to fill a 99 gridwith digits so that each column, each row, and each of the nine 3x3 subgrids that compose thegrid (also called "boxes", "blocks", or "regions") contain all of the digits from 1 to 9. The puzzlesetter provides a partially completed grid, which for a well-posed puzzle has a single solution.\
The backtracking  algorithm  to  solve  the  puzzle  is  business  logic  and  is  part  of  the model. A text based UI sits on top of this, allowing the user to specify the size of the puzzle to generate (4 or 9 grid) and the difficulty of the puzzle (easy, medium, hard), and output the solution to a puzzle as well as the puzzle for the user to solve. Difficulties will be specified by the user but follow the same principle regardless of the size of the puzzle:\
Easy - 40% of spaces are blankMedium - 55% of spaces are blankHard - 75% of spaces are blankOnce the solution is generated, you should randomly select spaces in the puzzle to make themblank based on the rules above.The following is output from a hard 9x9 puzzle:--------+-------+--------| 1 3 4 | 9 7 8 | 2 5 6 || 8 7 6 | 2 3 5 | 1 4 9 || 2 5 9 | 1 4 6 | 3 8 7 |--------+-------+--------| 6 9 3 | 4 5 2 | 7 1 8 || 4 1 2 | 8 6 7 | 9 3 5 || 5 8 7 | 3 1 9 | 6 2 4 |--------+-------+--------| 9 2 1 | 7 8 4 | 5 6 3 || 7 4 5 | 6 2 3 | 8 9 1 || 3 6 8 | 5 9 1 | 4 7 2 |--------+-------+----------------+-------+--------| X 3 X | X X X | 2 X X || 8 7 X | 2 X X | 1 X X || X X 9 | 1 X 6 | X X X |--------+-------+--------| X X X | 4 X X | X X X || X X X | X X X | X 3 5 || X X X | X X 9 | X 2 X |--------+-------+--------| X X 1 | X 8 X | X 6 3 || X X 5 | X X X | X X X || X X X | X X 1 | 4 X X |--------+-------+--------
