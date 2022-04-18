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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Attempts = 5;
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = Mainframe;
        }

        private void Mainframe_ContentRendered(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var Username = TBoxLogin.Text;
            var Password = PBoxPass.Password;

            if (!(Username == "inspector" & Password == "inspector"))
            {
                Attempts = Attempts - 1;
                if (Attempts == 0)
                    Application.Current.Shutdown();
                MessageBox.Show($"Wrong username or password \n Attempts left = {Attempts}");
                return;
            };

            Manager.MainFrame.Navigate(new ReadDriverPage());
            StackPanel.Visibility = Visibility.Hidden;
            Attempts = 5;
        }
    }
}
