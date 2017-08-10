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

        #region TopMenuBar

        Boolean isMaximized;
        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mnuMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void mnuMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (isMaximized != true)
            {
                this.WindowState = WindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                isMaximized = false;
            }

            
            
        }

        private void lblTitleBarCenter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        #endregion

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

        private void ImageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            seperator4.Fill = Brushes.Orange;
            seperator5.Fill = Brushes.Orange;
        }

        private void ImageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            seperator4.Fill = (Brush)bc.ConvertFrom("#FF606060");            
            seperator5.Fill = (Brush)bc.ConvertFrom("#FF606060");
        }

        private void ImageButton_MouseEnter_1(object sender, MouseEventArgs e)
        {
            seperator4.Fill = Brushes.Orange;
            seperator3.Fill = Brushes.Orange;
        }

        private void ImageButton_MouseLeave_1(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            seperator4.Fill = (Brush)bc.ConvertFrom("#FF606060");
            seperator3.Fill = (Brush)bc.ConvertFrom("#FF606060");
        }

        private void ImageButton_MouseEnter_2(object sender, MouseEventArgs e)
        {
            seperator3.Fill = Brushes.Orange;
            seperator2.Fill = Brushes.Orange;
        }

        private void ImageButton_MouseLeave_2(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            seperator3.Fill = (Brush)bc.ConvertFrom("#FF606060");
            seperator2.Fill = (Brush)bc.ConvertFrom("#FF606060");
        }



        private void imgbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            seperator2.Fill = Brushes.Orange;
            seperator1.Fill = Brushes.Orange;
        }

        private void imgbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            seperator2.Fill = (Brush)bc.ConvertFrom("#FF606060");
            seperator1.Fill = (Brush)bc.ConvertFrom("#FF606060");
        }

        private void imgBtn4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            imgBtn4.Background = (Brush)bc.ConvertFrom("#FF555555");
        }

        private void imgBtn4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            imgBtn4.Background = (Brush)bc.ConvertFrom("#FF3A3A3A");
        }

        
    }


}
