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
        private bool _infinity = true;
        public RecordPage()
        {
            InitializeComponent();
            Place.Text = "Привет";
        }

        public Visibility Visible { get; private set; }
        public Visibility Hidden { get; private set; }

        private void ChoiceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChoiceBox.Items.IsInUse == true)
            {
                Choice2Box.Visibility = Visible;
                StackRecord.Visibility = Visible;
            }
           
        }

        private void Choice2Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }


        private void Check()
        {
            if (StackRecord.Children != null)
            {
                btnRecord.Visibility = Visible;
                Place.Text = "";
            }
       
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               
                    if (Place.Text != null)
                    {
                        Check();
                    }
                    else if (Name.Text != null)
                    {
                        Check();
                    }
                    else
                    {
                        MessageBox.Show("Bad result");
                    }
                
           
            }
            catch (Exception)
            {
                throw;
            }
          
        }
    }
}
