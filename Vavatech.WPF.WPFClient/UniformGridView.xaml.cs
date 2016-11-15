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

namespace Vavatech.WPF.WPFClient
{
    /// <summary>
    /// Interaction logic for UniformGridView.xaml
    /// </summary>
    public partial class UniformGridView : Window
    {
        public UniformGridView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = e.OriginalSource as Button;
            
            MessageBox.Show($"{button.Content} clicked!");

            e.Handled = true;
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Window clicked!");
        }
    }
}
