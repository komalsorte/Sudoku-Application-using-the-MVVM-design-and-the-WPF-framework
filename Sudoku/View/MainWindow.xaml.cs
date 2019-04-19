using Sudoku.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sudoku.View;

/// <summary>
/// Author: Komal Sorte
/// Project 2 Phase 2 : Generate Sudoku puzzle using backtracking, pruning.
/// </summary>
/// 
namespace Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public SudokuViewModel _viewModel;
        private TextBox selectedTxtxBx;
        internal DifficultyLevel _viewLevel;
        internal NoWin _viewNoWin;
        internal Win _viewWin;
        internal int currentSelection;
        internal bool reveal = false;

        #region . Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region . Properties
        internal SudokuViewModel PuzzleViewModel
        {
            get
            {
                return _viewModel;
            }
            set
            {
                _viewModel = value;                             // Save a pointer to the ViewModel class
                this.DataContext = value;                       // Set the datacontext of the WPF form to the view model.
            }
        }
        #endregion

        #region . Methods

        /// <summary>
        /// Executes on selection of cell
        /// </summary>
        internal void txtBx_OnGotFocus(object sender, RoutedEventArgs e)
        {
            selectedTxtxBx = (TextBox)sender;
            currentSelection = Int32.Parse(selectedTxtxBx.Uid);
        }


        /// <summary>
        /// OnClick action for save button
        /// </summary>
        internal void btn_SavePuzzle(object sender, RoutedEventArgs e)
        {
            PuzzleViewModel.OnClickSavePuzzle();
        }

        /// <summary>
        /// OnClick action for new puzzle button
        /// </summary>
        internal void btn_NewPuzzle(object sender, RoutedEventArgs e)
        {
            ShowNewPuzzle();
        }


        /// <summary>
        /// OnClick action for reveal button
        /// </summary>
        internal void btn_Reveal(object sender, RoutedEventArgs e)
        {
            PuzzleViewModel.OnClickRevealPuzzleCell();
        }

        /// <summary>
        /// OnClick action for validate button
        /// </summary>
        internal void btn_ValidatePuzzle(object sender, RoutedEventArgs e)
        {
            PuzzleViewModel.OnClickValidatePuzzle();
        }


        /// <summary>
        /// Shows window to choose difficulty level
        /// </summary>
        internal void ShowDifficultyLevelBox()
        {
            _viewLevel = new DifficultyLevel(_viewModel);
            _viewLevel.Owner = this;
            _viewLevel.ShowDialog();
        }

        /// <summary>
        /// Shows new puzzle
        /// </summary>
        internal void ShowNewPuzzle()
        {
            if (PuzzleViewModel != null)
                PuzzleViewModel.OnClickSetDifficultyLevel();
            if (PuzzleViewModel != null)
                PuzzleViewModel.OnClickNewPuzzle();
        }

        /// <summary>
        /// Shows window if user loses
        /// </summary>
        internal void ShowNoWinBox()
        {
            _viewNoWin = new NoWin(_viewModel);
            _viewNoWin.Owner = this;
            _viewNoWin.ShowDialog();
        }

        /// <summary>
        /// Shows window if user wins
        /// </summary>
        internal void ShowWinBox()
        {
            _viewWin = new Win(_viewModel);
            _viewWin.Owner = this;
            _viewWin.ShowDialog();
        }
        #endregion


    }
}
