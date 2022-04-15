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
        public Services1()
        {
            InitializeComponent();
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
