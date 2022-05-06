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
        int id;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(int iduser)
        {
            InitializeComponent();
            id = iduser;
            MessageBox.Show($"{id}");
            if (AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id) != null)
            {
                LoginTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
                NameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name;
                SecondNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName;
                LastNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName;
                PhoneTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone;
                LoadImage.ImageSource =  new BitmapImage(new Uri(AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).ImagePath)); ;
                NickNameTb.Text = AutoLandEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Login;
            }

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
    }
}
