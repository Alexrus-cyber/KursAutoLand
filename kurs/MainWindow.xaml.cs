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

namespace kurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new Home());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButtonNews_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
        }

        private void RadioButtonAction_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Action());
        }
    }
}
