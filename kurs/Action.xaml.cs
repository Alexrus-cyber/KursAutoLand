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
    /// Логика взаимодействия для Action.xaml
    /// </summary>
    public partial class Action : Page
    {
        private int id;
        private int idclients;
        public Action(int iduser , int idclient)
        {
            InitializeComponent();
            id = iduser;
            idclients = idclient;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Services.Services1(id, idclients));
        }
    }
}
