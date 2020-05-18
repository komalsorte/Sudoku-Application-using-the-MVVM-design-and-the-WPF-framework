# Sudoku application using the MVVM design and the WPF framework

An application with a 3-tier model i.e. MVVM (Observable, Mediator, Singleton design patterns) that can generate Sudoku puzzles of varying difficulty using backtracking.\
Project has been divided into two phases:\
o Phase 1: Generate solutions for 4x4 or 9x9 puzzles.\
o Phase 2: Generate puzzles for solutions from Phase 1 that the end user could solve.

Utilized Technologies/Software: .net framework 4.7, C#, Visual Studio 2017, XAML, WPF Framework

## Design ##
Sudoku puzzles are logic puzzles typically on a 9x9 grid, where the objective is to fill a 99 gridwith digits so that each column, each row, and each of the nine 3x3 subgrids that compose thegrid (also called "boxes", "blocks", or "regions") contain all of the digits from 1 to 9. The puzzlesetter provides a partially completed grid, which for a well-posed puzzle has a single solution.\
The backtracking  algorithm  to  solve  the  puzzle  is  business  logic  and  is  part  of  the model. A text based UI sits on top of this, allowing the user to specify the size of the puzzle to generate (4 or 9 grid) and the difficulty of the puzzle (easy, medium, hard), and output the solution to a puzzle as well as the puzzle for the user to solve. Difficulties will be specified by the user but follow the same principle regardless of the size of the puzzle:\
o Easy - 40% of spaces are blank\
o Medium - 55% of spaces are blank\
o Hard - 75% of spaces are blank\
Once the solution is generated, the program randomly selects spaces in the puzzle to make them blank based on the rules above.\
The following is output from a hard 9x9 puzzle:\
<img src="https://github.com/komalsorte/Sudoku-Application-using-the-MVVM-design-and-the-WPF-framework/blob/master/Sudoku/SudokuBackend.png" width="30%" height="30%" />
