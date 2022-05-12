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

namespace kurs.Services
{
    /// <summary>
    /// Логика взаимодействия для Services1.xaml
    /// </summary>
    public partial class Services1 : Page
    {
        private int id;
        private int idclients;
        public Services1(int iduser, int idclient)
        {
            InitializeComponent();
            id = iduser;
            idclients = idclient;
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RecordPage(id, idclients));
        }
    }
}
