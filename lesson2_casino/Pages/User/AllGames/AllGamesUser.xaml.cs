using lesson2_casino.Pages.User.Game1LuckiJet;
using lesson2_casino.Pages.User.ProfilePage;
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

namespace lesson2_casino.Pages.User.AllGames
{
    /// <summary>
    /// Логика взаимодействия для AllGamesUser.xaml
    /// </summary>
    public partial class AllGamesUser : Page
    {
        string login;
        public AllGamesUser(string LOGIN)
        {
            InitializeComponent();
            this.login = LOGIN;
        }

        private void Game1Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new Game1LuckyJet(login));
        }
    }
}
