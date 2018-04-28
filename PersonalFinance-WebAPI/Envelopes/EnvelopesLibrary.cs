using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.Envelopes
{
    public class EnvelopesLibrary
    {
        public List<EnvelopeItem> GetEnvelopes()
        {
            List<DAL.AccountTransactionItem> acct = DAL.AccountTransactionsDAL.GetAccountTransactions();
            List<DAL.BudgetItem> budget = DAL.BudgetDAL.GetBudget();

            List<EnvelopeItem> e = BudgetSummary(budget);
            EnvelopeItem updateItem = new EnvelopeItem();
            foreach (DAL.AccountTransactionItem item in acct)
            {
                updateItem = (from i in e
                              where i.description == item.TransactionCategory.Category
                              select i).FirstOrDefault();
                if (updateItem == null)
                {
                    updateItem = new EnvelopeItem();
                    e.Add(updateItem);
                    updateItem.description = item.TransactionCategory.Category;
                    updateItem.amountBudgeted = 0;
                }

                updateItem.amountUsed = updateItem.amountUsed + item.Amount;
                updateItem.amountRemaining = updateItem.amountBudgeted - updateItem.amountUsed;
            }

            return e;
        }

        private List<EnvelopeItem> BudgetSummary(List<DAL.BudgetItem> bi)
        {
            return (from item in bi
                       select new EnvelopeItem
                       {
                           description = item.BudgetCategory.Category,
                           amountBudgeted = item.BudgetAmount,
                           amountRemaining = item.BudgetAmount
                       }).ToList();
        }
       
    }
}