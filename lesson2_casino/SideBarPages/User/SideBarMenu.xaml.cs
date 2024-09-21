using lesson2_casino.Pages.components;
using lesson2_casino.Pages.HomePage;
using lesson2_casino.Pages.User.AllGames;
using lesson2_casino.Pages.User.ProfilePage;
using lesson2_casino.SideBarPages.Admin;
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

namespace lesson2_casino.SideBarPages
{
    /// <summary>
    /// Логика взаимодействия для SideBarMenu.xaml
    /// </summary>
    public partial class SideBarMenu : Page
    {
        string login;

        public SideBarMenu(string login)
        {
            InitializeComponent();
            this.login = login; 
            Profile.Content ="Профиль: " + Convert.ToString(login);
        }

        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new ProfilePageUser(login));
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new HomePage());
        }

        private void AllGames_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new AllGamesUser(login));
        }
    }
}
