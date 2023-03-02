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

namespace WpfApp1
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
        private void TextBox_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button1.Width = 0;
                Button1.Height = 0;
                Title += "1";
            }
        }
        private void TextBox_MouseRightButtonDown1(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button2.Width = 0;
                Button2.Height = 0;
                Title += "2";
            }
        }
        private void TextBox_MouseRightButtonDown2(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button3.Width = 0;
                Button3.Height = 0;
                Title += "3";
            }
        }

        private void TextBox_MouseRightButtonDown3(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button4.Width = 0;
                Button4.Height = 0;
                Title += "4";
            }
        }

        private void TextBox_MouseRightButtonDown4(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button5.Width = 0;
                Button5.Height = 0;
                Title += "5";
            }
        }

        private void TextBox_MouseRightButtonDown5(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button6.Width = 0;
                Button6.Height = 0;
                Title += "6";
            }
        }

        Random r = new Random();
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255),
                (byte)r.Next(1, 233)));
            Button1.Background = brush;
            MessageBox.Show($"Color={brush.ToString()}");

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255),
                (byte)r.Next(1, 233)));
            Button2.Background = brush;
            MessageBox.Show($"Color={brush.ToString()}");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255),
                (byte)r.Next(1, 233)));
            Button3.Background = brush;
            MessageBox.Show($"Color={brush.ToString()}");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255),
                (byte)r.Next(1, 233)));
            Button4.Background = brush;
            MessageBox.Show($"Color={brush.ToString()}");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255),
                (byte)r.Next(1, 233)));
            Button5.Background = brush;
            MessageBox.Show($"Color={brush.ToString()}");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255),
                (byte)r.Next(1, 233)));
            Button6.Background = brush;
            MessageBox.Show($"Color={brush.ToString()}");
        }
    }
}
