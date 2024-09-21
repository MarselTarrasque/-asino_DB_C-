using lesson2_casino.Classes;
using lesson2_casino.DataBase;
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

namespace lesson2_casino.Pages.User.HistoryOfTransactionsUser
{
    public partial class HistoryOfTransactions : Page
    {
        string login;
        public HistoryOfTransactions(string LOGIN)
        {
            InitializeComponent();
            this.login = LOGIN;
            LoadTransactionHistory();
        }

        private void GoBackbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void LoadTransactionHistory()
    {
        int userId = DBConn.DBCONNECT.Client.FirstOrDefault(user => user.Login == login).ID_Client;
        var transactionHistoryRaw = (from transaction in DBConn.DBCONNECT.Transaction
        where transaction.Id_Client == userId
        join withdrawal in DBConn.DBCONNECT.Withdrawal_Transaction on transaction.Id_trasaction equals withdrawal.Id_trasaction into withdrawals
        from withdrawal in withdrawals.DefaultIfEmpty() 
        join replenishment in DBConn.DBCONNECT.Replenishment_transaction on transaction.Id_trasaction equals replenishment.Id_trasaction into replenishments
        from replenishment in replenishments.DefaultIfEmpty()
        select new
        {
            ID_Transaction = transaction.Id_trasaction,
            Name_Transaction = withdrawal != null ? withdrawal.Name_Transaction : (replenishment != null ? replenishment.Name_Transaction : "Неизвестная транзакция"),
            Sum_of_transaction = withdrawal != null ? withdrawal.Sum : (replenishment != null ? replenishment.Sum : 0), 
            Date = transaction.Date_Of_Transaction,
        }).ToList();

    var transactionHistory = transactionHistoryRaw.Select(th => new TransactionHistory
    {
        ID_Transaction = th.ID_Transaction,
        Name_Transaction = th.Name_Transaction,
        Sum_of_withdrawal =Convert.ToDecimal(th.Sum_of_transaction),
        Date = Convert.ToDateTime(th.Date),
    }).ToList();

    ListHistoryGames.ItemsSource = transactionHistory;
}
    }
}
