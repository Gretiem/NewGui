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

namespace NewGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnButtonTest_MouseEnter(object sender, MouseEventArgs e)
        {
            //btnButtonTest.Background = Brushes.SkyBlue;
            btnButtonTest.BorderBrush = Brushes.White;
        }

        private void btnButtonTest_MouseLeave(object sender, MouseEventArgs e)
        {
            btnButtonTest.Background = Brushes.DeepSkyBlue;
            btnButtonTest.BorderBrush = Brushes.Black;
        }

        private void btnButtonTest_Click(object sender, RoutedEventArgs e)
        {
            btnButtonTest.Background = Brushes.SkyBlue;
            btnButtonTest.BorderBrush = Brushes.Black;
            //MessageBox.Show("click");

            string thisHeight = Application.Current.MainWindow.ActualWidth.ToString();
            MessageBox.Show(thisHeight);
        }

        private void getWidth()
        {
            string thisWidth = Application.Current.MainWindow.ActualWidth.ToString();
            
        }

        private void btnTesting_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }
    }


}
