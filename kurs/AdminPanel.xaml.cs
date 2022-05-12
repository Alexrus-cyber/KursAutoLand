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

namespace kurs
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        private int idrec;
        public AdminPanel()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new Home());
            idrec = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == 7).Id_client;
        }
        private void RadioButtonNews_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
        }

        private void RadioButtonAction_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Action(7,3));
        }


        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TurnApp_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void DragApp_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
            }
            else this.WindowState = WindowState.Normal;
        }


        private void Myprofile(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Profile(7,3));
        }



        private void Record_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RecordPage(7,3));
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Base(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DataBlock(idrec));
        }
    }
}
