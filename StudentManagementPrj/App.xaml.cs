﻿using StudentManagementPrj.Store;
using StudentManagementPrj.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudentManagementPrj
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //NavigationStore navigationStore = new NavigationStore();
            //navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
            //MainWindow MainWd = new MainWindow()
            //{
            //    DataContext = new MainViewModel(navigationStore)
            //};
            //MainWindow.Show();
            //base.OnStartup(e);
            var newMainWindow = new MainWindow();

            // Show the new main window
            newMainWindow.Show();

        }
    }
}
