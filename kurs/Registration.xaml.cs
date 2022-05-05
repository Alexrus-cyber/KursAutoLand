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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    
    public partial class Registration : Window
    {

        private User _currentUser = new User();
        public Registration()
        {
            DataContext = _currentUser;
            InitializeComponent();
        }

        private void btnReg_click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text.Length <= 2)
            {
                LoginTb.ToolTip = "Поле введено не корректно";
                MessageBox.Show("Логин должен быть минимум из 3 символов");
            }
            else if (LoginTb.Text.Length >= 9)
            {
                LoginTb.ToolTip = "Поле введено не корректно";
                MessageBox.Show("Логин должен быть максимум из 10 символов");
            }
            else if (PasswordTb.Text.Length <= 7)
            {
                PasswordTb.ToolTip = "Поле введено не корректно";
                MessageBox.Show("Пароль должен быть минимум из 8 символов");
            }
            else if (PasswordTb.Text.Length >= 11)
            {
                PasswordTb.ToolTip = "Поле введено не корректно";
                MessageBox.Show("Пароль должен быть максимум из 12 символов");
            }
            else if (PasswordTb.Text != Pass.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else if (EmailTb.Text.Length <= 12)
            {
                MessageBox.Show("Вы ввели некоректный email or gmail");
            }
            else
            {

                if (EmailTb.Text.Contains("@mail.ru") || EmailTb.Text.Contains("@gmail.ru"))
                {
                    bool canRegister = AutoLandEntities.GetContext().Users.All(p => p.Login != LoginTb.Text.Trim() || p.Email != EmailTb.Text.Trim());
                    if (canRegister)
                    {
                        AutoLandEntities.GetContext().Users.Add(new User { Login = LoginTb.Text.Trim(), Email = EmailTb.Text.Trim(), Password = PasswordTb.Text.Trim() });
                        AutoLandEntities.GetContext().SaveChanges();
                        MessageBox.Show("Вы прошли регистрацию");
                        Door door = new Door();
                        door.Show();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Ебать ты даун");
                    }

                }
                else
                {
                    MessageBox.Show("Используйте только gmail или mail");
                }
               

            }
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
