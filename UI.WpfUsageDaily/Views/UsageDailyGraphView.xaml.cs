﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Owlsure.UI.WpfUsageDaily.ViewModels;
using System.Diagnostics;

namespace Owlsure.UI.WpfUsageDaily.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UsageDailyGraphView : UserControl
    {
        public UsageDailyGraphView(UsageDailyViewModel viewModel)
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                this.DataContext = viewModel;
            };
        }

        public string Header { get { return "Graph"; } }

        private void amChart_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Here");
        }

        private void amChart_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Here");

        }

        private void amChart_GotFocus(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Here");

        }
    }
}
