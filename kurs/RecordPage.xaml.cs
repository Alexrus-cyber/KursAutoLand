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
    /// Логика взаимодействия для RecordPage.xaml
    /// </summary>
    public partial class RecordPage : Page
    {
        private int id;
        private int idclient;
        public RecordPage(int iduser, int idclients)
        {
            InitializeComponent();
            id = iduser;
            idclient = idclients;
          
                NameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name;
                SecondNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName;
                LastNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName;
                PhoneTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone;   
            
            
        }

        public Visibility Visible { get; private set; }
        public Visibility Hidden { get; private set; }

        private void ChoiceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Name;
            SecondNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).SecondName;
            LastNameTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).LastName;
            PhoneTb.Text = AutoLandEntities.GetContext().Clients.FirstOrDefault(p => p.Id_user == id).Phone;

            if (Item1.IsSelected == true)
            {
                Choice2Box.Visibility = Visible;
                StackRecord.Visibility = Visible;
                Choice21Box.Visibility = Visibility.Collapsed;
                Item2.IsSelected = false;
            }
            else if (Item2.IsSelected == true)
            {
                Choice21Box.Visibility = Visible;
                Choice2Box.Visibility = Visibility.Collapsed;
                StackRecord.Visibility = Visible;
                Item1.IsSelected = false;
            }
           
        }

        private void Choice2Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Choice2Box.Items.Count != 0)
            {
                btnRecord.Visibility = Visibility.Visible;
            }
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
           
            string savetext = "";
            if (Item1.IsSelected == true)
            {
               savetext = Choice2Box.Text;
               
            }
            else
            {
                savetext = Choice21Box.Text;
         
            }
            AutoLandEntities.GetContext().Records.Add(new Record { Id_client = idclient, Location = LocationTb.Text, Service = savetext});
           
            MessageBox.Show("Вы успешно записались");
            Manager.MainFrame.Navigate(new Home());
            AutoLandEntities.GetContext().SaveChanges();
        }

        private void LocationTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LocationTb.Text != "")
            {
                if (LocationTb.Text.Length > 3)
                {
                    btnRecord.Visibility = Visibility.Visible;
                }
                else
                {
                    btnRecord.Visibility = Visibility.Collapsed;
                }
                
            }
            else
            {
                btnRecord.Visibility = Visibility.Collapsed;
            }
        }
    }
}
