//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lesson2_casino.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Withdrawal_Transaction
    {
        public int ID_of_withdrawal { get; set; }
        public Nullable<double> Sum { get; set; }
        public string Name_Transaction { get; set; }
        public Nullable<int> Id_trasaction { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
