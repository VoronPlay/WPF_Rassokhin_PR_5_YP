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

namespace WPF_Rassokhin_PR_5_YP
{
    /// <summary>
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void home(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page10();
        }

        private void inbox(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page11();
        }

        private void sent_items(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page12();
        }

        private void settings(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page13();
        }

        private void spam(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page14();
        }
    }
}
