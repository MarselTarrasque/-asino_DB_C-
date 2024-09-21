using lesson2_casino.DataBase;
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

namespace lesson2_casino.Pages.User.ReplenishPageUser
{
    /// <summary>
    /// Логика взаимодействия для ReplenishPageUser.xaml
    /// </summary>
    public partial class ReplenishPageUser : Page
    {
        string login;
        public ReplenishPageUser(string LOGIN)
        {
            InitializeComponent();
            this.login = LOGIN;
        }

        private void GoBackbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Replenich_Click(object sender, RoutedEventArgs e)
        {
            if (SBPCheckBox.IsChecked == true) { 
                if(Convert.ToInt32(SummTxt.Text) < 100)
                {
                    minsumm.Foreground = Brushes.Red;
                    SummTxt.BorderBrush = Brushes.Red;
                }
                else
                {
                    var tempUser = DBConn.DBCONNECT.Client.FirstOrDefault(user => user.Login == login);
                    int plusbal = (int)tempUser.Balance;
                    tempUser.Balance = plusbal + Convert.ToInt32(SummTxt.Text);
                    DBConn.DBCONNECT.SaveChanges();
                    var tempTransaction = new Transaction() { Id_Client = tempUser.ID_Client, Date_Of_Transaction = DateTime.Today };
                    DBConn.DBCONNECT.Transaction.Add(tempTransaction);

                    var tempReplenishment = new Replenishment_transaction()
                    {
                        Id_trasaction = tempTransaction.Id_trasaction,
                        Name_Transaction = "Пополнение",
                        Sum = Convert.ToInt32(SummTxt.Text)
                    };
                    DBConn.DBCONNECT.Replenishment_transaction.Add(tempReplenishment);
                    DBConn.DBCONNECT.SaveChanges();
                    
                    MainWindow.Instance.FRAME.Navigate(new ProfilePageUser(login));
                }
            }
            else
            {
                MessageBox.Show("Выберите способ оплаты!!");
            }
        }

        private void SummTxt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            minsumm.Foreground = Brushes.Gray;
            SummTxt.BorderBrush = Brushes.Gray;
        }
    }
}
