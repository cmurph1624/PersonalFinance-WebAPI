using PersonalFinance_WebAPI.Library.AccountSummary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PersonalFinance_WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AccountSummaryController : ApiController
    {
        // GET: api/AccountSummary
        public IEnumerable<AccountSummaryItem> Get()
        {
            //List<AccountTransactionItem> a = new List<AccountTransactionItem>()
            //{
            //    new AccountTransactionItem() {ID = 1,
            //                                    Description ="Test 1",
            //                                    Amount = 25,
            //                                    TransactionDate = DateTime.Now,
            //                                    TransactionCategory = new CategoryItem(){ID = 1,
            //                                                                            Category = "Food"} },

            List<AccountSummaryItem> a = new List<AccountSummaryItem>()
            {
                new AccountSummaryItem() {ID = 1,
                                             AccountName = "1st Bank Checking",
                                             AccountBalance = 1000,
                                             DateUpdated = DateTime.Now},
                new AccountSummaryItem() {ID = 2,
                                             AccountName = "1st Bank Saving",
                                             AccountBalance = 2000,
                                             DateUpdated = DateTime.Now},
            };
            return a;
        }

        // GET: api/AccountSummary/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AccountSummary
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AccountSummary/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AccountSummary/5
        public void Delete(int id)
        {
        }
    }
}
