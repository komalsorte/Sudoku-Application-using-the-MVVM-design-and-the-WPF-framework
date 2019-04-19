using Sudoku.Model;
using Sudoku.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author: Komal Sorte
/// Project 2 Phase 2 : Generate Sudoku puzzle using backtracking, pruning.
/// </summary>
namespace Sudoku.ViewModel
{
    public class SudokuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private SudokuModel _model;
        private MainWindow _viewWindow;
        private string difficulty = " ";
        private bool[] isEnabled = new bool[81];
        private bool result = true;
        private string puzzleText;
        private bool buttonEnabled = false;


        #region . Constructors .

        // Declared private so no one else can.
        public SudokuViewModel(MainWindow window)
        {
            _viewWindow = window;
            _viewWindow.ShowNewPuzzle();
            _model = new SudokuModel("9", "easy");
        }

        #endregion


        public string Difficulty
        {
            get => difficulty;
            set => difficulty = value;
        }



        #region . Properties: Enable .

        public bool isButtonEnabled
        {
            get => buttonEnabled;

        }
        #region . Properties: Col 1 Enable
        public bool isEnabled00
        {
            get => isEnabled[0];

        }
        public bool isEnabled10
        {
            get => isEnabled[9];
        }

        public bool isEnabled20
        {
            get => isEnabled[18];
        }

        public bool isEnabled30
        {
            get => isEnabled[27];
        }

        public bool isEnabled40
        {
            get => isEnabled[36];
        }

        public bool isEnabled50
        {
            get => isEnabled[45];
        }

        public bool isEnabled60
        {
            get => isEnabled[54];
        }

        public bool isEnabled70
        {
            get => isEnabled[63];
        }

        public bool isEnabled80
        {
            get => isEnabled[72];
        }
        #endregion

        #region . Properties: Col 2 Enable
        public bool isEnabled01
        {
            get => isEnabled[1];

        }
        public bool isEnabled11
        {
            get => isEnabled[10];
        }

        public bool isEnabled21
        {
            get => isEnabled[19];
        }

        public bool isEnabled31
        {
            get => isEnabled[28];
        }

        public bool isEnabled41
        {
            get => isEnabled[37];
        }

        public bool isEnabled51
        {
            get => isEnabled[46];
        }

        public bool isEnabled61
        {
            get => isEnabled[55];
        }

        public bool isEnabled71
        {
            get => isEnabled[64];
        }

        public bool isEnabled81
        {
            get => isEnabled[73];
        }
        #endregion

        #region . Properties: Col 3 Enable
        public bool isEnabled02
        {
            get => isEnabled[2];

        }
        public bool isEnabled12
        {
            get => isEnabled[11];
        }

        public bool isEnabled22
        {
            get => isEnabled[20];
        }

        public bool isEnabled32
        {
            get => isEnabled[29];
        }

        public bool isEnabled42
        {
            get => isEnabled[38];
        }

        public bool isEnabled52
        {
            get => isEnabled[47];
        }

        public bool isEnabled62
        {
            get => isEnabled[56];
        }

        public bool isEnabled72
        {
            get => isEnabled[65];
        }

        public bool isEnabled82
        {
            get => isEnabled[74];
        }
        #endregion

        #region . Properties: Col 4 Enable
        public bool isEnabled03
        {
            get => isEnabled[3];

        }
        public bool isEnabled13
        {
            get => isEnabled[12];
        }

        public bool isEnabled23
        {
            get => isEnabled[21];
        }

        public bool isEnabled33
        {
            get => isEnabled[30];
        }

        public bool isEnabled43
        {
            get => isEnabled[39];
        }

        public bool isEnabled53
        {
            get => isEnabled[48];
        }

        public bool isEnabled63
        {
            get => isEnabled[57];
        }

        public bool isEnabled73
        {
            get => isEnabled[66];
        }

        public bool isEnabled83
        {
            get => isEnabled[75];
        }
        #endregion

        #region . Properties: Col 5 Enable
        public bool isEnabled04
        {
            get => isEnabled[4];

        }
        public bool isEnabled14
        {
            get => isEnabled[13];
        }

        public bool isEnabled24
        {
            get => isEnabled[22];
        }

        public bool isEnabled34
        {
            get => isEnabled[31];
        }

        public bool isEnabled44
        {
            get => isEnabled[40];
        }

        public bool isEnabled54
        {
            get => isEnabled[49];
        }

        public bool isEnabled64
        {
            get => isEnabled[58];
        }

        public bool isEnabled74
        {
            get => isEnabled[67];
        }

        public bool isEnabled84
        {
            get => isEnabled[76];
        }
        #endregion

        #region . Properties: Col 6 Enable
        public bool isEnabled05
        {
            get => isEnabled[5];

        }
        public bool isEnabled15
        {
            get => isEnabled[14];
        }

        public bool isEnabled25
        {
            get => isEnabled[23];
        }

        public bool isEnabled35
        {
            get => isEnabled[32];
        }

        public bool isEnabled45
        {
            get => isEnabled[41];
        }

        public bool isEnabled55
        {
            get => isEnabled[50];
        }

        public bool isEnabled65
        {
            get => isEnabled[59];
        }

        public bool isEnabled75
        {
            get => isEnabled[68];
        }

        public bool isEnabled85
        {
            get => isEnabled[77];
        }
        #endregion

        #region . Properties: Col 7 Enable
        public bool isEnabled06
        {
            get => isEnabled[6];

        }
        public bool isEnabled16
        {
            get => isEnabled[15];
        }

        public bool isEnabled26
        {
            get => isEnabled[24];
        }

        public bool isEnabled36
        {
            get => isEnabled[33];
        }

        public bool isEnabled46
        {
            get => isEnabled[42];
        }

        public bool isEnabled56
        {
            get => isEnabled[51];
        }

        public bool isEnabled66
        {
            get => isEnabled[60];
        }

        public bool isEnabled76
        {
            get => isEnabled[69];
        }

        public bool isEnabled86
        {
            get => isEnabled[78];
        }
        #endregion

        #region . Properties: Col 8 Enable
        public bool isEnabled07
        {
            get => isEnabled[7];

        }
        public bool isEnabled17
        {
            get => isEnabled[16];
        }

        public bool isEnabled27
        {
            get => isEnabled[25];
        }

        public bool isEnabled37
        {
            get => isEnabled[34];
        }

        public bool isEnabled47
        {
            get => isEnabled[43];
        }

        public bool isEnabled57
        {
            get => isEnabled[52];
        }

        public bool isEnabled67
        {
            get => isEnabled[61];
        }

        public bool isEnabled77
        {
            get => isEnabled[70];
        }

        public bool isEnabled87
        {
            get => isEnabled[79];
        }
        #endregion

        #region . Properties: Col 9 Enable
        public bool isEnabled08
        {
            get => isEnabled[8];

        }
        public bool isEnabled18
        {
            get => isEnabled[17];
        }

        public bool isEnabled28
        {
            get => isEnabled[26];
        }

        public bool isEnabled38
        {
            get => isEnabled[35];
        }

        public bool isEnabled48
        {
            get => isEnabled[44];
        }

        public bool isEnabled58
        {
            get => isEnabled[53];
        }

        public bool isEnabled68
        {
            get => isEnabled[62];
        }

        public bool isEnabled78
        {
            get => isEnabled[71];
        }

        public bool isEnabled88
        {
            get => isEnabled[80];
        }
        #endregion
        #endregion


        #region . Properties: Cell Contents .

        // Property pointers to individual cells of the puzzle.

        #region . Properties: Col 1 Cells .
        public int Cell00
        {
            get
            {
                return _model.PuzzleBoard[0, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 0])
                {
                    _model.PuzzleBoard[0, 0] = value;
                    OnPropertyChanged("Cell00");
                }
            }
        }

        public int Cell10
        {
            get
            {
                return _model.PuzzleBoard[1, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 0])
                {
                    _model.PuzzleBoard[1, 0] = value;
                    OnPropertyChanged("Cell10");
                }
            }
        }


        public int Cell20
        {
            get
            {
                return _model.PuzzleBoard[2, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 0])
                {
                    _model.PuzzleBoard[2, 0] = value;
                    OnPropertyChanged("Cell20");
                }
            }
        }
        public int Cell30
        {
            get
            {
                return _model.PuzzleBoard[3, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 0])
                {
                    _model.PuzzleBoard[3, 0] = value;
                    OnPropertyChanged("Cell30");
                }
            }
        }
        public int Cell40
        {
            get
            {
                return _model.PuzzleBoard[4, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 0])
                {
                    _model.PuzzleBoard[4, 0] = value;
                    OnPropertyChanged("Cell40");
                }
            }
        }
        public int Cell50
        {
            get
            {
                return _model.PuzzleBoard[5, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 0])
                {
                    _model.PuzzleBoard[5, 0] = value;
                    OnPropertyChanged("Cell50");
                }
            }
        }
        public int Cell60
        {
            get
            {
                return _model.PuzzleBoard[6, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 0])
                {
                    _model.PuzzleBoard[6, 0] = value;
                    OnPropertyChanged("Cell60");
                }
            }
        }
        public int Cell70
        {
            get
            {
                return _model.PuzzleBoard[7, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 0])
                {
                    _model.PuzzleBoard[7, 0] = value;
                    OnPropertyChanged("Cell70");
                }
            }
        }
        public int Cell80
        {
            get
            {
                return _model.PuzzleBoard[8, 0];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 0])
                {
                    _model.PuzzleBoard[8, 0] = value;
                    OnPropertyChanged("Cell80");
                }
            }
        }

        #endregion

        #region . Properties: Col 2 Cells .
        public int Cell01
        {
            get
            {
                return _model.PuzzleBoard[0, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 1])
                {
                    _model.PuzzleBoard[0, 1] = value;
                    OnPropertyChanged("Cell01");
                }
            }
        }

        public int Cell11
        {
            get
            {
                return _model.PuzzleBoard[1, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 1])
                {
                    _model.PuzzleBoard[1, 1] = value;
                    OnPropertyChanged("Cell11");
                }
            }
        }

        public int Cell21
        {
            get
            {
                return _model.PuzzleBoard[2, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 1])
                {
                    _model.PuzzleBoard[2, 1] = value;
                    OnPropertyChanged("Cell21");
                }
            }
        }

        public int Cell31
        {
            get
            {
                return _model.PuzzleBoard[3, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 1])
                {
                    _model.PuzzleBoard[3, 1] = value;
                    OnPropertyChanged("Cell31");
                }
            }
        }

        public int Cell41
        {
            get
            {
                return _model.PuzzleBoard[4, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 1])
                {
                    _model.PuzzleBoard[4, 1] = value;
                    OnPropertyChanged("Cell41");
                }
            }
        }

        public int Cell51
        {
            get
            {
                return _model.PuzzleBoard[5, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 1])
                {
                    _model.PuzzleBoard[5, 1] = value;
                    OnPropertyChanged("Cell51");
                }
            }
        }

        public int Cell61
        {
            get
            {
                return _model.PuzzleBoard[6, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 1])
                {
                    _model.PuzzleBoard[6, 1] = value;
                    OnPropertyChanged("Cell61");
                }
            }
        }

        public int Cell71
        {
            get
            {
                return _model.PuzzleBoard[7, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 1])
                {
                    _model.PuzzleBoard[7, 1] = value;
                    OnPropertyChanged("Cell71");
                }
            }
        }

        public int Cell81
        {
            get
            {
                return _model.PuzzleBoard[8, 1];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 1])
                {
                    _model.PuzzleBoard[8, 1] = value;
                    OnPropertyChanged("Cell81");
                }
            }
        }

        #endregion

        #region . Properties: Col 3 Cells .
        public int Cell02
        {
            get
            {
                return _model.PuzzleBoard[0, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 2])
                {
                    _model.PuzzleBoard[0, 2] = value;
                    OnPropertyChanged("Cell02");
                }
            }
        }

        public int Cell12
        {
            get
            {
                return _model.PuzzleBoard[1, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 2])
                {
                    _model.PuzzleBoard[1, 2] = value;
                    OnPropertyChanged("Cell12");
                }
            }
        }

        public int Cell22
        {
            get
            {
                return _model.PuzzleBoard[2, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 2])
                {
                    _model.PuzzleBoard[2, 2] = value;
                    OnPropertyChanged("Cell22");
                }
            }
        }

        public int Cell32
        {
            get
            {
                return _model.PuzzleBoard[3, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 2])
                {
                    _model.PuzzleBoard[3, 2] = value;
                    OnPropertyChanged("Cell32");
                }
            }
        }

        public int Cell42
        {
            get
            {
                return _model.PuzzleBoard[4, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 2])
                {
                    _model.PuzzleBoard[4, 2] = value;
                    OnPropertyChanged("Cell42");
                }
            }
        }

        public int Cell52
        {
            get
            {
                return _model.PuzzleBoard[5, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 2])
                {
                    _model.PuzzleBoard[5, 2] = value;
                    OnPropertyChanged("Cell52");
                }
            }
        }

        public int Cell62
        {
            get
            {
                return _model.PuzzleBoard[6, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 2])
                {
                    _model.PuzzleBoard[6, 2] = value;
                    OnPropertyChanged("Cell62");
                }
            }
        }

        public int Cell72
        {
            get
            {
                return _model.PuzzleBoard[7, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 2])
                {
                    _model.PuzzleBoard[7, 2] = value;
                    OnPropertyChanged("Cell72");
                }
            }
        }

        public int Cell82
        {
            get
            {
                return _model.PuzzleBoard[8, 2];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 2])
                {
                    _model.PuzzleBoard[8, 2] = value;
                    OnPropertyChanged("Cell82");
                }
            }
        }

        #endregion

        #region . Properties: Col 4 Cells .
        public int Cell03
        {
            get
            {
                return _model.PuzzleBoard[0, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 3])
                {
                    _model.PuzzleBoard[0, 3] = value;
                    OnPropertyChanged("Cell03");
                }
            }
        }

        public int Cell13
        {
            get
            {
                return _model.PuzzleBoard[1, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 3])
                {
                    _model.PuzzleBoard[1, 3] = value;
                    OnPropertyChanged("Cell13");
                }
            }
        }

        public int Cell23
        {
            get
            {
                return _model.PuzzleBoard[2, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 3])
                {
                    _model.PuzzleBoard[2, 3] = value;
                    OnPropertyChanged("Cell23");
                }
            }
        }

        public int Cell33
        {
            get
            {
                return _model.PuzzleBoard[3, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 3])
                {
                    _model.PuzzleBoard[3, 3] = value;
                    OnPropertyChanged("Cell33");
                }
            }
        }

        public int Cell43
        {
            get
            {
                return _model.PuzzleBoard[4, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 3])
                {
                    _model.PuzzleBoard[4, 3] = value;
                    OnPropertyChanged("Cell43");
                }
            }
        }

        public int Cell53
        {
            get
            {
                return _model.PuzzleBoard[5, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 3])
                {
                    _model.PuzzleBoard[5, 3] = value;
                    OnPropertyChanged("Cell53");
                }
            }
        }

        public int Cell63
        {
            get
            {
                return _model.PuzzleBoard[6, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 3])
                {
                    _model.PuzzleBoard[6, 3] = value;
                    OnPropertyChanged("Cell63");
                }
            }
        }

        public int Cell73
        {
            get
            {
                return _model.PuzzleBoard[7, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 3])
                {
                    _model.PuzzleBoard[7, 3] = value;
                    OnPropertyChanged("Cell73");
                }
            }
        }

        public int Cell83
        {
            get
            {
                return _model.PuzzleBoard[8, 3];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 3])
                {
                    _model.PuzzleBoard[8, 3] = value;
                    OnPropertyChanged("Cell83");
                }
            }
        }

        #endregion

        #region . Properties: Col 5 Cells .
        public int Cell04
        {
            get
            {
                return _model.PuzzleBoard[0, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 4])
                {
                    _model.PuzzleBoard[0, 4] = value;
                    OnPropertyChanged("Cell04");
                }
            }
        }

        public int Cell14
        {
            get
            {
                return _model.PuzzleBoard[1, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 4])
                {
                    _model.PuzzleBoard[1, 4] = value;
                    OnPropertyChanged("Cell14");
                }
            }
        }

        public int Cell24
        {
            get
            {
                return _model.PuzzleBoard[2, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 4])
                {
                    _model.PuzzleBoard[2, 4] = value;
                    OnPropertyChanged("Cell24");
                }
            }
        }

        public int Cell34
        {
            get
            {
                return _model.PuzzleBoard[3, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 4])
                {
                    _model.PuzzleBoard[3, 4] = value;
                    OnPropertyChanged("Cell34");
                }
            }
        }

        public int Cell44
        {
            get
            {
                return _model.PuzzleBoard[4, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 4])
                {
                    _model.PuzzleBoard[4, 4] = value;
                    OnPropertyChanged("Cell44");
                }
            }
        }

        public int Cell54
        {
            get
            {
                return _model.PuzzleBoard[5, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 4])
                {
                    _model.PuzzleBoard[5, 4] = value;
                    OnPropertyChanged("Cell54");
                }
            }
        }

        public int Cell64
        {
            get
            {
                return _model.PuzzleBoard[6, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 4])
                {
                    _model.PuzzleBoard[6, 4] = value;
                    OnPropertyChanged("Cell64");
                }
            }
        }

        public int Cell74
        {
            get
            {
                return _model.PuzzleBoard[7, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 4])
                {
                    _model.PuzzleBoard[7, 4] = value;
                    OnPropertyChanged("Cell74");
                }
            }
        }

        public int Cell84
        {
            get
            {
                return _model.PuzzleBoard[8, 4];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 4])
                {
                    _model.PuzzleBoard[8, 4] = value;
                    OnPropertyChanged("Cell84");
                }
            }
        }

        #endregion

        #region . Properties: Col 6 Cells .
        public int Cell05
        {
            get
            {
                return _model.PuzzleBoard[0, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 5])
                {
                    _model.PuzzleBoard[0, 5] = value;
                    OnPropertyChanged("Cell05");
                }
            }
        }

        public int Cell15
        {
            get
            {
                return _model.PuzzleBoard[1, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 5])
                {
                    _model.PuzzleBoard[1, 5] = value;
                    OnPropertyChanged("Cell15");
                }
            }
        }

        public int Cell25
        {
            get
            {
                return _model.PuzzleBoard[2, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 5])
                {
                    _model.PuzzleBoard[2, 5] = value;
                    OnPropertyChanged("Cell25");
                }
            }
        }

        public int Cell35
        {
            get
            {
                return _model.PuzzleBoard[3, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 5])
                {
                    _model.PuzzleBoard[3, 5] = value;
                    OnPropertyChanged("Cell35");
                }
            }
        }

        public int Cell45
        {
            get
            {
                return _model.PuzzleBoard[4, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 5])
                {
                    _model.PuzzleBoard[4, 5] = value;
                    OnPropertyChanged("Cell45");
                }
            }
        }

        public int Cell55
        {
            get
            {
                return _model.PuzzleBoard[5, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 5])
                {
                    _model.PuzzleBoard[5, 5] = value;
                    OnPropertyChanged("Cell55");
                }
            }
        }

        public int Cell65
        {
            get
            {
                return _model.PuzzleBoard[6, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 5])
                {
                    _model.PuzzleBoard[6, 5] = value;
                    OnPropertyChanged("Cell65");
                }
            }
        }

        public int Cell75
        {
            get
            {
                return _model.PuzzleBoard[7, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 5])
                {
                    _model.PuzzleBoard[7, 5] = value;
                    OnPropertyChanged("Cell75");
                }
            }
        }

        public int Cell85
        {
            get
            {
                return _model.PuzzleBoard[8, 5];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 5])
                {
                    _model.PuzzleBoard[8, 5] = value;
                    OnPropertyChanged("Cell85");
                }
            }
        }

        #endregion

        #region . Properties: Col 7 Cells .
        public int Cell06
        {
            get
            {
                return _model.PuzzleBoard[0, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 6])
                {
                    _model.PuzzleBoard[0, 6] = value;
                    OnPropertyChanged("Cell06");
                }
            }
        }

        public int Cell16
        {
            get
            {
                return _model.PuzzleBoard[1, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 6])
                {
                    _model.PuzzleBoard[1, 6] = value;
                    OnPropertyChanged("Cell16");
                }
            }
        }

        public int Cell26
        {
            get
            {
                return _model.PuzzleBoard[2, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 6])
                {
                    _model.PuzzleBoard[2, 6] = value;
                    OnPropertyChanged("Cell26");
                }
            }
        }

        public int Cell36
        {
            get
            {
                return _model.PuzzleBoard[3, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 6])
                {
                    _model.PuzzleBoard[3, 6] = value;
                    OnPropertyChanged("Cell36");
                }
            }
        }

        public int Cell46
        {
            get
            {
                return _model.PuzzleBoard[4, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 6])
                {
                    _model.PuzzleBoard[4, 6] = value;
                    OnPropertyChanged("Cell46");
                }
            }
        }

        public int Cell56
        {
            get
            {
                return _model.PuzzleBoard[5, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 6])
                {
                    _model.PuzzleBoard[5, 6] = value;
                    OnPropertyChanged("Cell56");
                }
            }
        }

        public int Cell66
        {
            get
            {
                return _model.PuzzleBoard[6, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 6])
                {
                    _model.PuzzleBoard[6, 6] = value;
                    OnPropertyChanged("Cell66");
                }
            }
        }

        public int Cell76
        {
            get
            {
                return _model.PuzzleBoard[7, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 6])
                {
                    _model.PuzzleBoard[7, 6] = value;
                    OnPropertyChanged("Cell76");
                }
            }
        }

        public int Cell86
        {
            get
            {
                return _model.PuzzleBoard[8, 6];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 6])
                {
                    _model.PuzzleBoard[8, 6] = value;
                    OnPropertyChanged("Cell86");
                }
            }
        }

        #endregion

        #region . Properties: Col 8 Cells .
        public int Cell07
        {
            get
            {
                return _model.PuzzleBoard[0, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 7])
                {
                    _model.PuzzleBoard[0, 7] = value;
                    OnPropertyChanged("Cell07");
                }
            }
        }

        public int Cell17
        {
            get
            {
                return _model.PuzzleBoard[1, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 7])
                {
                    _model.PuzzleBoard[1, 7] = value;
                    OnPropertyChanged("Cell17");
                }
            }
        }

        public int Cell27
        {
            get
            {
                return _model.PuzzleBoard[2, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 7])
                {
                    _model.PuzzleBoard[2, 7] = value;
                    OnPropertyChanged("Cell27");
                }
            }
        }

        public int Cell37
        {
            get
            {
                return _model.PuzzleBoard[3, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 7])
                {
                    _model.PuzzleBoard[3, 7] = value;
                    OnPropertyChanged("Cell37");
                }
            }
        }

        public int Cell47
        {
            get
            {
                return _model.PuzzleBoard[4, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 7])
                {
                    _model.PuzzleBoard[4, 7] = value;
                    OnPropertyChanged("Cell47");
                }
            }
        }

        public int Cell57
        {
            get
            {
                return _model.PuzzleBoard[5, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 7])
                {
                    _model.PuzzleBoard[5, 7] = value;
                    OnPropertyChanged("Cell57");
                }
            }
        }

        public int Cell67
        {
            get
            {
                return _model.PuzzleBoard[6, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 7])
                {
                    _model.PuzzleBoard[6, 7] = value;
                    OnPropertyChanged("Cell67");
                }
            }
        }

        public int Cell77
        {
            get
            {
                return _model.PuzzleBoard[7, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 7])
                {
                    _model.PuzzleBoard[7, 7] = value;
                    OnPropertyChanged("Cell77");
                }
            }
        }

        public int Cell87
        {
            get
            {
                return _model.PuzzleBoard[8, 7];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 7])
                {
                    _model.PuzzleBoard[8, 7] = value;
                    OnPropertyChanged("Cell87");
                }
            }
        }

        #endregion

        #region . Properties: Col 9 Cells .
        public int Cell08
        {
            get
            {
                return _model.PuzzleBoard[0, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[0, 8])
                {
                    _model.PuzzleBoard[0, 8] = value;
                    OnPropertyChanged("Cell08");
                }
            }
        }

        public int Cell18
        {
            get
            {
                return _model.PuzzleBoard[1, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[1, 8])
                {
                    _model.PuzzleBoard[1, 8] = value;
                    OnPropertyChanged("Cell18");
                }
            }
        }

        public int Cell28
        {
            get
            {
                return _model.PuzzleBoard[2, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[2, 8])
                {
                    _model.PuzzleBoard[2, 8] = value;
                    OnPropertyChanged("Cell28");
                }
            }
        }

        public int Cell38
        {
            get
            {
                return _model.PuzzleBoard[3, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[3, 8])
                {
                    _model.PuzzleBoard[3, 8] = value;
                    OnPropertyChanged("Cell38");
                }
            }
        }

        public int Cell48
        {
            get
            {
                return _model.PuzzleBoard[4, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[4, 8])
                {
                    _model.PuzzleBoard[4, 8] = value;
                    OnPropertyChanged("Cell48");
                }
            }
        }

        public int Cell58
        {
            get
            {
                return _model.PuzzleBoard[5, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[5, 8])
                {
                    _model.PuzzleBoard[5, 8] = value;
                    OnPropertyChanged("Cell58");
                }
            }
        }

        public int Cell68
        {
            get
            {
                return _model.PuzzleBoard[6, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[6, 8])
                {
                    _model.PuzzleBoard[6, 8] = value;
                    OnPropertyChanged("Cell68");
                }
            }
        }

        public int Cell78
        {
            get
            {
                return _model.PuzzleBoard[7, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[7, 8])
                {
                    _model.PuzzleBoard[7, 8] = value;
                    OnPropertyChanged("Cell78");
                }
            }
        }

        public int Cell88
        {
            get
            {
                return _model.PuzzleBoard[8, 8];
            }
            set
            {
                if (value != _model.PuzzleBoard[8, 8])
                {
                    _model.PuzzleBoard[8, 8] = value;
                    OnPropertyChanged("Cell88");
                }
            }
        }

        #endregion

        #endregion

        #region . Methods
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Generates new puzzle
        /// </summary>
        internal void OnClickNewPuzzle()
        {
            _model = new SudokuModel("9", Difficulty);
            _model.GenerateSudokuPuzzle();                    // Is there a valid game?
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (_model.PuzzleBoard[row, col] != 0)
                        isEnabled[row * 9 + col] = false;
                    else
                        isEnabled[row * 9 + col] = true;
                    OnPropertyChanged("isEnabled" + row + col);
                    

                    OnPropertyChanged("Cell" + row + col);

                    if (_model.PuzzleBoard[row, col] == 0)
                        puzzleText = puzzleText + "X";
                    else
                        puzzleText = puzzleText + _model.PuzzleBoard[row, col];
                    if (col != 8)
                        puzzleText = puzzleText + " ";
                    else if (col == 8)
                        puzzleText = puzzleText + "\n";
                }
            }
            buttonEnabled = true;
            OnPropertyChanged("isButtonEnabled");
        }

        /// <summary>
        /// Sets difficulty level
        /// </summary>
        internal void OnClickSetDifficultyLevel()
        {
            _viewWindow.ShowDifficultyLevelBox();
        }

        /// <summary>
        /// Validates Solution
        /// </summary>
        internal void OnClickValidatePuzzle()
        {
            result = true;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (_model.PuzzleBoard[row, col] != _model.PuzzleSolution[row, col])
                    {
                        result = false;
                        break;
                    }
                }
            }
            if (result)
                _viewWindow.ShowWinBox();

            else
                _viewWindow.ShowNoWinBox();
        }

        /// <summary>
        /// Reveales value for selected cell
        /// </summary>
        internal void OnClickRevealPuzzleCell()
        {
            int row = _viewWindow.currentSelection / 10;
            int col = _viewWindow.currentSelection % 10;


            _model.PuzzleBoard[row, col] = _model.PuzzleSolution[row, col];
            OnPropertyChanged("Cell" + row + col);
        }

        /// <summary>
        /// Saves original puzzle in file
        /// </summary>
        internal void OnClickSavePuzzle()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            TextWriter txt = new StreamWriter(path+"\\puzzleBoard.txt");
            txt.Write(puzzleText);
            txt.Close();
        }

        #endregion

    }
}
