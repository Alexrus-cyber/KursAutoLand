using Microsoft.Win32;
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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
      private int id;
      private int idclients;
      private MainWindow main;
       
        public Profile(int iduser , int idclient, MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            id = iduser;
            idclients = idclient; 
            LoginTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
            NameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name;
            SecondNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName;
            LastNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName;
            PhoneTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone;
            LoadImage.ImageSource = new BitmapImage(new Uri(AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).ImagePath)); 
            NickNameTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
            
        }
        public Profile(int iduser, int idclient)
        {
            InitializeComponent();
            id = iduser;
            idclients = idclient;
            LoginTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
            NameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name;
            SecondNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName;
            LastNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName;
            PhoneTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone;
            LoadImage.ImageSource = new BitmapImage(new Uri(AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).ImagePath));
            NickNameTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login = LoginTb.Text;
            AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name = NameTb.Text;
            AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName = SecondNameTb.Text;
            AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName = LastNameTb.Text;
            AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone = PhoneTb.Text;
            AutoLandEntities.GetContext().SaveChanges();
            MessageBox.Show("Вы сохранены");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
            "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            if (ofdPicture.ShowDialog() == true)
            {
                LoadImage.ImageSource = new BitmapImage(new Uri(ofdPicture.FileName));
                AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).ImagePath = ofdPicture.FileName;
                AutoLandEntities.GetContext().SaveChanges();
            }
        }

     
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            LoginTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
            NameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name;
            SecondNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName;
            LastNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName;
            PhoneTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone;
           //LoadImage.ImageSource = new BitmapImage(new Uri(AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).ImagePath)) ;
            NickNameTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
          
           
                var item = AutoLandEntities.GetContext().Users.Where(p => p.Id_user == id).FirstOrDefault();
                var item1 = AutoLandEntities.GetContext().Clients.Where(p => p.Id_user == id).FirstOrDefault();
                var item2 = AutoLandEntities.GetContext().Records.Where(p => p.Id_client == idclients).FirstOrDefault();
                if (item2 != null)
                {
                    if (MessageBox.Show($"Вы точно хотите удалите данного пользователя {id}", "Alarm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        AutoLandEntities.GetContext().Users.Remove(item);
                        AutoLandEntities.GetContext().Clients.Remove(item1);
                        AutoLandEntities.GetContext().Records.Remove(item2);
                        AutoLandEntities.GetContext().SaveChanges();
                        MessageBox.Show("Вы удалили себя досвидания");


                        Door door = new Door();
                        door.Show();
                    if (main != null)
                    {
                        main.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Фухх вы не удалились :)");
                }
                }
                else
                {
                    if (MessageBox.Show($"Вы точно хотите удалите данного пользователя {id}", "Alarm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        AutoLandEntities.GetContext().Users.Remove(item);
                        AutoLandEntities.GetContext().Clients.Remove(item1);
                        AutoLandEntities.GetContext().SaveChanges();
                        MessageBox.Show("Вы удалили себя досвидания");

                        Door door = new Door();
                        door.Show();
                    if (main != null)
                    {
                        main.Close();
                    }
                }
                    else
                    {
                    MessageBox.Show("Фухх вы не удалились :)");
                    }
               
            }
               
               
            }
        
            
    }
}
