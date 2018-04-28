using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.Library.AccountSummary
{
    public class AccountSummaryItem
    {
        //    ID: number;
        //AccountDescription: string;
        //AccountBalance: number;
        //DateUpdated: Date;
        public int ID;
        public string AccountName;
        public decimal AccountBalance;
        public DateTime DateUpdated;
    }
}