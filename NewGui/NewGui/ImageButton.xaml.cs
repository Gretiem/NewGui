using System;
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

namespace NewGui
{
    /// <summary>
    /// Interaction logic for ImageButton.xaml
    /// </summary>
    public partial class ImageButton : UserControl
    {
        public ImageSource DisabledImage
        {
            get { return (ImageSource)GetValue(DisabledImageProperty); }
            set { SetValue(DisabledImageProperty, value); }
        }
        public static readonly DependencyProperty DisabledImageProperty =
            DependencyProperty.Register("DisabledImage", typeof(ImageSource), typeof(ImageButton), new UIPropertyMetadata(null));

        public ImageSource SecondImage
        {
            get { return (ImageSource)GetValue(SecondImageProperty);  }
            set { SetValue(SecondImageProperty, value); }
        }
        public static readonly DependencyProperty SecondImageProperty =
            DependencyProperty.Register("SecondImage", typeof(ImageSource), typeof(ImageButton), new UIPropertyMetadata(null));

        public ImageSource NormalImage
        {
            get { return (ImageSource)GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }
        public static readonly DependencyProperty NormalImageProperty =
            DependencyProperty.Register("NormalImage", typeof(ImageSource), typeof(ImageButton), new UIPropertyMetadata(null));

        public String TxtBlockValue
        {
            get { return (String)GetValue(TxtBlockValueProperty); }
            set { SetValue(TxtBlockValueProperty, value); }
        }
        public static DependencyProperty TxtBlockValueProperty =
            DependencyProperty.Register("TxtBlockValue", typeof(String), typeof(ImageButton), new UIPropertyMetadata(null));



        public event RoutedEventHandler Click;

        public ImageButton()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }
    }
}
