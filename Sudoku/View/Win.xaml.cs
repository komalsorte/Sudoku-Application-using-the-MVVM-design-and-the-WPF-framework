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

/// <summary>
/// Author: Komal Sorte
/// Project 2 Phase 2 : Generate Sudoku puzzle using backtracking, pruning.
/// </summary>
namespace Sudoku.View
{
    /// <summary>
    /// Interaction logic for Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        public SudokuViewModel _viewModel;
        #region
        public Win(SudokuViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }
        #endregion


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

        #region . Form Event Handlers .
        /// <summary>
        /// OnClick action for OK button
        /// </summary>
        private void btn_ClickOK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
