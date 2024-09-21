using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_casino.Classes
{
    public class TransactionHistory
    {
        public int ID_Transaction { get; set; } // ID транзакции
        public string Name_Transaction { get; set; } // Имя операции
        public decimal Sum_of_withdrawal { get; set; } // Сумма вывода
        public DateTime Date { get; set; } //Дата
    }
}
