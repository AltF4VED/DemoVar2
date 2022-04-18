
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

namespace DemoVar2
{
    /// <summary>
    /// Логика взаимодействия для ReadDriverPage.xaml
    /// </summary>
    public partial class ReadDriverPage : Page
    {
        public ReadDriverPage()
        {
            var Drivers = DatabaseContext.db.Driver.ToList();
            InitializeComponent();
            LViewDriver.ItemsSource = Drivers;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDriverPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var peopleToRemove = LViewDriver.SelectedItems.Cast<drivers>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {peopleToRemove.Count()} элементов?", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DatabaseContext.db.Driver.RemoveRange(peopleToRemove);
                    DatabaseContext.db.SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    LViewDriver.ItemsSource = DatabaseContext.db.Driver.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void LViewDriver_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDriverPage(LViewDriver.SelectedItem as drivers));
        }
    }
}
