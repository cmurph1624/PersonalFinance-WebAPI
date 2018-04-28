using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalFinance_WebAPI.Envelopes;

namespace PersonalFinance_UnitTest
{
    [TestClass]
    public class EnvelopeLibraryTest
    {
        [TestMethod]
        public void GetAcctTransSummaryMultipleItemsEnvelope()
        {
            
            EnvelopesLibrary el = new EnvelopesLibrary();
            List<PersonalFinance_WebAPI.Envelopes.EnvelopeItem> items = el.GetEnvelopes();
            var actual = (from EnvelopeItem i in items where i.description == "Food" select i.amountUsed).FirstOrDefault(); ;
            int expected = 55;
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void GetEnvelopeAccountTransNoBudget()
        {
            EnvelopesLibrary el = new EnvelopesLibrary();
            List<EnvelopeItem> items = el.GetEnvelopes();
            var actual = (from EnvelopeItem i in items where i.description == "Cable" select i.amountRemaining).FirstOrDefault();

            int expected = -55;
            Assert.AreEqual(actual, expected);
        }
    }
}
