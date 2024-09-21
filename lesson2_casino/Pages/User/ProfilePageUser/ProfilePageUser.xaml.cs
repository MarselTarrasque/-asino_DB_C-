using lesson2_casino.DataBase;
using System;
using System.Collections.Generic;
using lesson2_casino.Pages.User.HistoryOfTransactionsUser;
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

namespace lesson2_casino.Pages.User.ProfilePage
{
    /// <summary>
    /// Логика взаимодействия для ProfilePageUser.xaml
    /// </summary>
    public partial class ProfilePageUser : Page
    {
        string login;
        public ProfilePageUser(string LOGIN)
        {
            InitializeComponent();
            this.login = LOGIN;
            LabelName.Text = "Профиль пользователя: " + Convert.ToString(login);
            var USER = DBConn.DBCONNECT.Client.FirstOrDefault(name => name.Login == login);
            DateTime registrationDate = Convert.ToDateTime(USER.Date_of_registration);
            string formattedDate = registrationDate.ToString("dd.MM.yyyy");
            LabelDate.Text = "Дата регистрации: " + formattedDate;
            LabelBalance.Text = "Баланс: " + USER.Balance;
        }
        private void Replenish_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new ReplenishPageUser.ReplenishPageUser(login));
        }

        private void Conclusion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new ConclusionPageUser.ConclusionPageUser(login));
        }

        private void HistoryOfTranzactions_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.FRAME.Navigate(new HistoryOfTransactions(login));
        }
    }
}
