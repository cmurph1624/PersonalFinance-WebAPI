using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.DAL
{
    public static class BudgetDAL
    {
        private static List<BudgetItem> _budgetItems;

        public static List<BudgetItem> BudgetItems
        {
            get
            {
                if (_budgetItems == null)
                {
                    _budgetItems = BuildBudgetItem();
                }
                return _budgetItems;
            }
            set
            {

            }
        }

        public static List<BudgetItem> GetBudget()
        {
            return BudgetItems;
        }

        private static List<BudgetItem> BuildBudgetItem()
        {
            List<BudgetItem> a = new List<BudgetItem>()
            {
                new BudgetItem() {ID = 1,
                                                Description ="Test 1",
                                                 BudgetAmount = 25,
                                                 EndDate = DateTime.Now,
                                                 BudgetCategory = new CategoryItem(){ID = 1,
                                                                                        Category = "Food"} },
                new BudgetItem() {ID = 2,
                                                Description ="Test 2",
                                                 BudgetAmount = 30,
                                                 EndDate = DateTime.Now,
                                                 BudgetCategory = new CategoryItem(){ID = 2,
                                                                                        Category = "Rent"} },
                new BudgetItem() {ID = 1,
                                                Description ="Test 3",
                                                 BudgetAmount = 12,
                                                 EndDate = DateTime.Now,
                                                 BudgetCategory = new CategoryItem(){ID = 3,
                                                                                        Category = "Phone"} },
            };
            return a;
        }
    }
}