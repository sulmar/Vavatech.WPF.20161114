﻿using System;
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

namespace Vavatech.Bicycle.WPFClient.Views
{
    /// <summary>
    /// Interaction logic for StationsView.xaml
    /// </summary>
    public partial class StationsView : Window
    {
        public StationsView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModels.StationsViewModel;

            vm.SelectedStation.Number = "ST 100";
        }
    }
}
