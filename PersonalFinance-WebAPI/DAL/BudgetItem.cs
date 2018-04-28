using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.DAL
{
    public class BudgetItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public CategoryItem BudgetCategory { get; set; }
        public decimal BudgetAmount { get; set; }
        public DateTime BeginingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}