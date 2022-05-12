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
    /// Логика взаимодействия для DataBlock.xaml
    /// </summary>
    public partial class DataBlock : Page
    {
        private int id;
        public DataBlock(int idrecord)
        {
            InitializeComponent();
            id = idrecord;

            DGridRecords.ItemsSource = AutoLandEntities.GetContext().Records.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            
            
            var rec = DGridRecords.SelectedItems.Cast<Record>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие элементы {rec.Count()}?" ,"Alarm" , MessageBoxButton.YesNo,MessageBoxImage.Question)== MessageBoxResult.Yes)
            {
                AutoLandEntities.GetContext().Records.RemoveRange(rec);

                AutoLandEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы удалили");
                DGridRecords.ItemsSource = AutoLandEntities.GetContext().Records.ToList();
            }
          

        }

        private void DGridRecords_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AutoLandEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridRecords.ItemsSource = AutoLandEntities.GetContext().Records.ToList();
            }
        }
    }
}
