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

namespace Ch14Ex01
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, bubbling up");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, tunneling down");
            e.Handled = true;
        }

        private void RotatedButton_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("RotatedButton handler, bubbling up");
        }

        private void RotatedButton_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("RotatedButton handler, tunneling down");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, bubbling up");
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, tunneling down");
        }

        private void RotatedButtton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
