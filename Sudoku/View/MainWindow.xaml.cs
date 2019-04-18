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

namespace Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public SudokuViewModel _viewModel;
        internal DifficultyLevel _viewLevel;
        public MainWindow()
        {
            InitializeComponent();
        }


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
        internal void btn_NewPuzzle(object sender, RoutedEventArgs e)
        {
            ShowNewPuzzle();
        }

        internal void ShowDifficultyLevelBox()
        {
            _viewLevel = new DifficultyLevel(_viewModel);
            _viewLevel.Owner = this;
            _viewLevel.ShowDialog();
        }

        internal void ShowNewPuzzle()
        {
            if (PuzzleViewModel != null)
                PuzzleViewModel.OnClickSetDifficultyLevel();
            if (PuzzleViewModel != null)
                PuzzleViewModel.OnClickNewPuzzle();
        }


    }
}
