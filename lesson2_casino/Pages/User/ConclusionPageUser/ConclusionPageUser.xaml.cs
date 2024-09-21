using lesson2_casino.DataBase;
using lesson2_casino.Pages.User.ProfilePage;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace lesson2_casino.Pages.User.ConclusionPageUser
{
    /// <summary>
    /// Логика взаимодействия для ConclusionPageUser.xaml
    /// </summary>
    public partial class ConclusionPageUser : Page
    {
        string login;
        public ConclusionPageUser(string LOGIN)
        {
            InitializeComponent();
            this.login = LOGIN;
            var USER = DBConn.DBCONNECT.Client.FirstOrDefault(name => name.Login == login);
            Balance.Text = "Баланс: " + USER.Balance;
        }
        private void GoBackbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Replenich_Click(object sender, RoutedEventArgs e)
        {
            if (SBPCheckBox.IsChecked == true)
            {
                if (Convert.ToInt32(SummTxt.Text) < 100)
                {
                    minsumm.Foreground = Brushes.Red;
                    SummTxt.BorderBrush = Brushes.Red;
                }
                else
                {
                    var tempUser = DBConn.DBCONNECT.Client.FirstOrDefault(user => user.Login == login);
                    int minusbal = (int)tempUser.Balance;
                    if ((minusbal - Convert.ToInt32(SummTxt.Text)) >= 0)
                    {
                        tempUser.Balance = minusbal - Convert.ToInt32(SummTxt.Text);
                        DBConn.DBCONNECT.SaveChanges(); // Сохраняем изменения в клиенте

                        var tempTransaction = new Transaction()
                        {
                            Id_Client = tempUser.ID_Client,
                            Date_Of_Transaction = DateTime.Today
                        };
                        DBConn.DBCONNECT.Transaction.Add(tempTransaction);
                        DBConn.DBCONNECT.SaveChanges(); // Сохраняем изменения, чтобы получить Id_Transaction

                        // Теперь создаем вывод, используя правильный Id_Transaction
                        var tempWithdrawal = new Withdrawal_Transaction()
                        {
                            Id_trasaction = tempTransaction.Id_trasaction, // Используем Id_Transaction после сохранения
                            Name_Transaction = "Вывод",
                            Sum = Convert.ToDouble(SummTxt.Text)// Убедитесь, что тип совпадает
                        };
                        DBConn.DBCONNECT.Withdrawal_Transaction.Add(tempWithdrawal);

                        // Сохраняем изменения
                        DBConn.DBCONNECT.SaveChanges();

                        // Переход к странице профиля
                        MainWindow.Instance.FRAME.Navigate(new ProfilePageUser(login));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств для оплаты!!");
                    }
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
