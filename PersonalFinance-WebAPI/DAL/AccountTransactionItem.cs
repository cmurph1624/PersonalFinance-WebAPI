using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.DAL
{
    public class AccountTransactionItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public CategoryItem TransactionCategory { get; set; }
        

    }
}