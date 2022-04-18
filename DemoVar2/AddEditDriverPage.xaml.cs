
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
    /// Логика взаимодействия для AddEditDriverPage.xaml
    /// </summary>
    public partial class AddEditDriverPage : Page
    {
        private static drivers curDriver;
        public AddEditDriverPage(drivers driver)
        {
            if (driver == null)
                curDriver = new drivers();
            else
                curDriver = driver;
            InitializeComponent();
            DataContext = curDriver;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            DatabaseContext.db.Driver.Add(curDriver);
            DatabaseContext.db.SaveChanges();
            Manager.MainFrame.GoBack();
        }
    }
}
