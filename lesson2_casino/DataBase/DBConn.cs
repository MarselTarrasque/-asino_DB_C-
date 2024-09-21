using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_casino.DataBase
{
    internal class DBConn
    {
        public static Casino_Vulkan0oEntities5 DBCONNECT = new Casino_Vulkan0oEntities5();
        public static Client Client;
        public static Withdrawal_Transaction Withdrawal_Transaction;
        public static Transaction Transaction;
        public static Replenishment_transaction Replenishment_transaction;
    }
}
