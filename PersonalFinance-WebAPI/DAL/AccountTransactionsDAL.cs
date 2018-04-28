using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.DAL
{
    public static class AccountTransactionsDAL
    {
        private static List<AccountTransactionItem> _accountTransactions;
        private static List<AccountTransactionItem> accountTransactions
        { 
            get
            {
                if (_accountTransactions == null)
                {
                    _accountTransactions = BuildAccountTrasctions();
                }
                return _accountTransactions;
            }
            set
            {
            }
        }
        public static List<AccountTransactionItem> GetAccountTransactions()
        {            
            return accountTransactions;
        }

        private static List<AccountTransactionItem> BuildAccountTrasctions()
        {
            List<AccountTransactionItem> a = new List<AccountTransactionItem>()
            {
                new AccountTransactionItem() {ID = 1,
                                                Description ="Test 1",
                                                Amount = 25,
                                                TransactionDate = DateTime.Now,
                                                TransactionCategory = new CategoryItem(){ID = 1,
                                                                                        Category = "Food"} },
                new AccountTransactionItem() {ID = 2,
                                                Description ="Test 2",
                                                Amount = 30,
                                                TransactionDate = DateTime.Now,
                                                TransactionCategory = new CategoryItem(){ID = 1,
                                                                                        Category = "Food"} },
                new AccountTransactionItem() {ID = 3,
                                                Description ="Test 3",
                                                Amount = 55,
                                                TransactionDate = DateTime.Now,
                                                TransactionCategory = new CategoryItem(){ID = 5,
                                                                                        Category = "Cable"} }
            };
            return a;
        }
    }
}