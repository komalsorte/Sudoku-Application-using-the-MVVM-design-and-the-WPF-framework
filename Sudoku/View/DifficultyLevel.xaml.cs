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
using System.Windows.Shapes;

namespace Sudoku.View
{
    /// <summary>
    /// Interaction logic for DifficultyLevel.xaml
    /// </summary>
    public partial class DifficultyLevel : Window
    {
        public SudokuViewModel _viewModel;
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
        public DifficultyLevel(SudokuViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }

        private void btn_DifficultyEasy(object sender, RoutedEventArgs e)
        {
            PuzzleViewModel.Difficulty = "Easy";
            this.Close();
        }
        private void btn_DifficultyMedium(object sender, RoutedEventArgs e)
        {
            PuzzleViewModel.Difficulty = "Medium";
            this.Close();
        }
        private void btn_DifficultyHard(object sender, RoutedEventArgs e)
        {
            PuzzleViewModel.Difficulty = "Hard";
            this.Close();
        }
    }
}
