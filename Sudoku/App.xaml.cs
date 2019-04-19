using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Sudoku.ViewModel;

/// <summary>
/// Author: Komal Sorte
/// Project 2 Phase 2 : Generate Sudoku puzzle using backtracking, pruning.
/// </summary>
namespace Sudoku
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Sudoku.MainWindow window = new MainWindow();
            window._viewModel = new SudokuViewModel(window);
            window.DataContext = window._viewModel;
            window.Show();
        }
    }
}
