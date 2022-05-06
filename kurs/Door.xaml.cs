using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Door.xaml
    /// </summary>
    public partial class Door : Window
    {
        private User _currentUser;
        public Door()
        {
            DataContext = _currentUser;
            InitializeComponent();

        }

        private void btnDoor_click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text.Trim() == "AlexAdmin" && PasswordTb.Text == "AdminKet11" || LoginTb.Text.Trim() == "Admin@mail.ru" && PasswordTb.Text == "AdminKet11")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                Close();
            }
            else
            {
                
                bool successLogin = Logining(LoginTb.Text.Trim(), PasswordTb.Text.Trim());
                MessageBox.Show(successLogin ? "Вы вошли в систему" : "Зарегистрируйтесь, Вас не существует");
                if (successLogin == true)
                {
                    MainWindow main = new MainWindow(Log(LoginTb.Text.Trim(), PasswordTb.Text.Trim()).Id_user);
                    main.Show();
                    Close();
                }

            }
        }
        public bool Logining(string email , string pass)
        {
            return AutoLandEntities.GetContext().Users.Any(p => p.Email == email && p.Password == pass) ;
        }
        public User Log(string email, string pass)
        {
            return AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Email == email && p.Password == pass);
        }
        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
