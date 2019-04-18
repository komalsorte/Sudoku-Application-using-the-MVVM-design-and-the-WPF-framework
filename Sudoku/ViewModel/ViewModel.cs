using Sudoku.Model;
using Sudoku.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.ViewModel
{
    public class SudokuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private SudokuModel _model;
        private MainWindow _viewWindow;
        private string difficulty = " ";

        #region . Constructors .

        // Declared private so no one else can.
        public SudokuViewModel(MainWindow window)
        {
            _viewWindow = window;
            _viewWindow.ShowNewPuzzle();
        }

        #endregion


        public string Difficulty
        {
            get => difficulty;
            set => difficulty = value;
        }

        #region . Properties: Cell Contents .

        // Property pointers to individual cells of the puzzle.

        #region . Properties: Row 1 Cells .
        public int Cell00
        {
            get
            {
                return _model.PuzzleBoard[0, 0];
            }
        }
        public int Cell10
        {
            get
            {
                return _model.PuzzleBoard[1, 0];
            }
        }
        public int Cell20
        {
            get
            {
                return _model.PuzzleBoard[2, 0];
            }
        }
        public int Cell30
        {
            get
            {
                return _model.PuzzleBoard[3, 0];
            }
        }
        public int Cell40
        {
            get
            {
                return _model.PuzzleBoard[4, 0];
            }
        }
        public int Cell50
        {
            get
            {
                return _model.PuzzleBoard[5, 0];
            }
        }
        public int Cell60
        {
            get
            {
                return _model.PuzzleBoard[6, 0];
            }
        }
        public int Cell70
        {
            get
            {
                return _model.PuzzleBoard[7, 0];
            }
        }
        public int Cell80
        {
            get
            {
                return _model.PuzzleBoard[8, 0];
            }
        }

        #endregion

        #region . Properties: Row 2 Cells .
        public int Cell01
        {
            get
            {
                return _model.PuzzleBoard[0, 1];
            }
        }

        public int Cell11
        {
            get
            {
                return _model.PuzzleBoard[1, 1];
            }
        }

        public int Cell21
        {
            get
            {
                return _model.PuzzleBoard[2, 1];
            }
        }

        public int Cell31
        {
            get
            {
                return _model.PuzzleBoard[3, 1];
            }
        }

        public int Cell41
        {
            get
            {
                return _model.PuzzleBoard[4, 1];
            }
        }

        public int Cell51
        {
            get
            {
                return _model.PuzzleBoard[5, 1];
            }
        }

        public int Cell61
        {
            get
            {
                return _model.PuzzleBoard[6, 1];
            }
        }

        public int Cell71
        {
            get
            {
                return _model.PuzzleBoard[7, 1];
            }
        }

        public int Cell81
        {
            get
            {
                return _model.PuzzleBoard[8, 1];
            }
        }

        #endregion

        #region . Properties: Row 3 Cells .
        public int Cell02
        {
            get
            {
                return _model.PuzzleBoard[0, 2];
            }
        }

        public int Cell12
        {
            get
            {
                return _model.PuzzleBoard[1, 2];
            }
        }

        public int Cell22
        {
            get
            {
                return _model.PuzzleBoard[2, 2];
            }
        }

        public int Cell32
        {
            get
            {
                return _model.PuzzleBoard[3, 2];
            }
        }

        public int Cell42
        {
            get
            {
                return _model.PuzzleBoard[4, 2];
            }
        }

        public int Cell52
        {
            get
            {
                return _model.PuzzleBoard[5, 2];
            }
        }

        public int Cell62
        {
            get
            {
                return _model.PuzzleBoard[6, 2];
            }
        }

        public int Cell72
        {
            get
            {
                return _model.PuzzleBoard[7, 2];
            }
        }

        public int Cell82
        {
            get
            {
                return _model.PuzzleBoard[8, 2];
            }
        }

        #endregion

        #region . Properties: Row 4 Cells .
        public int Cell03
        {
            get
            {
                return _model.PuzzleBoard[0, 3];
            }
        }

        public int Cell13
        {
            get
            {
                return _model.PuzzleBoard[1, 3];
            }
        }

        public int Cell23
        {
            get
            {
                return _model.PuzzleBoard[2, 3];
            }
        }

        public int Cell33
        {
            get
            {
                return _model.PuzzleBoard[3, 3];
            }
        }

        public int Cell43
        {
            get
            {
                return _model.PuzzleBoard[4, 3];
            }
        }

        public int Cell53
        {
            get
            {
                return _model.PuzzleBoard[5, 3];
            }
        }

        public int Cell63
        {
            get
            {
                return _model.PuzzleBoard[6, 3];
            }
        }

        public int Cell73
        {
            get
            {
                return _model.PuzzleBoard[7, 3];
            }
        }

        public int Cell83
        {
            get
            {
                return _model.PuzzleBoard[8, 3];
            }
        }

        #endregion

        #region . Properties: Row 5 Cells .
        public int Cell04
        {
            get
            {
                return _model.PuzzleBoard[0, 4];
            }
        }

        public int Cell14
        {
            get
            {
                return _model.PuzzleBoard[1, 4];
            }
        }

        public int Cell24
        {
            get
            {
                return _model.PuzzleBoard[2, 4];
            }
        }

        public int Cell34
        {
            get
            {
                return _model.PuzzleBoard[3, 4];
            }
        }

        public int Cell44
        {
            get
            {
                return _model.PuzzleBoard[4, 4];
            }
        }

        public int Cell54
        {
            get
            {
                return _model.PuzzleBoard[5, 4];
            }
        }

        public int Cell64
        {
            get
            {
                return _model.PuzzleBoard[6, 4];
            }
        }

        public int Cell74
        {
            get
            {
                return _model.PuzzleBoard[7, 4];
            }
        }

        public int Cell84
        {
            get
            {
                return _model.PuzzleBoard[8, 4];
            }
        }

        #endregion

        #region . Properties: Row 6 Cells .
        public int Cell05
        {
            get
            {
                return _model.PuzzleBoard[0, 5];
            }
        }

        public int Cell15
        {
            get
            {
                return _model.PuzzleBoard[1, 5];
            }
        }

        public int Cell25
        {
            get
            {
                return _model.PuzzleBoard[2, 5];
            }
        }

        public int Cell35
        {
            get
            {
                return _model.PuzzleBoard[3, 5];
            }
        }

        public int Cell45
        {
            get
            {
                return _model.PuzzleBoard[4, 5];
            }
        }

        public int Cell55
        {
            get
            {
                return _model.PuzzleBoard[5, 5];
            }
        }

        public int Cell65
        {
            get
            {
                return _model.PuzzleBoard[6, 5];
            }
        }

        public int Cell75
        {
            get
            {
                return _model.PuzzleBoard[7, 5];
            }
        }

        public int Cell85
        {
            get
            {
                return _model.PuzzleBoard[8, 5];
            }
        }

        #endregion

        #region . Properties: Row 7 Cells .
        public int Cell06
        {
            get
            {
                return _model.PuzzleBoard[0, 6];
            }
        }

        public int Cell16
        {
            get
            {
                return _model.PuzzleBoard[1, 6];
            }
        }

        public int Cell26
        {
            get
            {
                return _model.PuzzleBoard[2, 6];
            }
        }

        public int Cell36
        {
            get
            {
                return _model.PuzzleBoard[3, 6];
            }
        }

        public int Cell46
        {
            get
            {
                return _model.PuzzleBoard[4, 6];
            }
        }

        public int Cell56
        {
            get
            {
                return _model.PuzzleBoard[5, 6];
            }
        }

        public int Cell66
        {
            get
            {
                return _model.PuzzleBoard[6, 6];
            }
        }

        public int Cell76
        {
            get
            {
                return _model.PuzzleBoard[7, 6];
            }
        }

        public int Cell86
        {
            get
            {
                return _model.PuzzleBoard[8, 6];
            }
        }

        #endregion

        #region . Properties: Row 8 Cells .
        public int Cell07
        {
            get
            {
                return _model.PuzzleBoard[0, 7];
            }
        }

        public int Cell17
        {
            get
            {
                return _model.PuzzleBoard[1, 7];
            }
        }

        public int Cell27
        {
            get
            {
                return _model.PuzzleBoard[2, 7];
            }
        }

        public int Cell37
        {
            get
            {
                return _model.PuzzleBoard[3, 7];
            }
        }

        public int Cell47
        {
            get
            {
                return _model.PuzzleBoard[4, 7];
            }
        }

        public int Cell57
        {
            get
            {
                return _model.PuzzleBoard[5, 7];
            }
        }

        public int Cell67
        {
            get
            {
                return _model.PuzzleBoard[6, 7];
            }
        }

        public int Cell77
        {
            get
            {
                return _model.PuzzleBoard[7, 7];
            }
        }

        public int Cell87
        {
            get
            {
                return _model.PuzzleBoard[8, 7];
            }
        }

        #endregion

        #region . Properties: Row 9 Cells .
        public int Cell08
        {
            get
            {
                return _model.PuzzleBoard[0, 8];
            }
        }

        public int Cell18
        {
            get
            {
                return _model.PuzzleBoard[1, 8];
            }
        }

        public int Cell28
        {
            get
            {
                return _model.PuzzleBoard[2, 8];
            }
        }

        public int Cell38
        {
            get
            {
                return _model.PuzzleBoard[3, 8];
            }
        }

        public int Cell48
        {
            get
            {
                return _model.PuzzleBoard[4, 8];
            }
        }

        public int Cell58
        {
            get
            {
                return _model.PuzzleBoard[5, 8];
            }
        }

        public int Cell68
        {
            get
            {
                return _model.PuzzleBoard[6, 8];
            }
        }

        public int Cell78
        {
            get
            {
                return _model.PuzzleBoard[7, 8];
            }
        }

        public int Cell88
        {
            get
            {
                return _model.PuzzleBoard[8, 8];
            }
        }

        #endregion

        #endregion
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void OnClickNewPuzzle()
        {
            _model = new SudokuModel("9", Difficulty);
            _model.GenerateSudokuPuzzle();                    // Is there a valid game?
            for(int row = 0; row < 9; row++){
                for (int col = 0; col < 9; col++)
                {
                    OnPropertyChanged("Cell"+row+col);
                }
            }            
        }

        internal void OnClickSetDifficultyLevel()
        {
            _viewWindow.ShowDifficultyLevelBox();
        }
    }
}
