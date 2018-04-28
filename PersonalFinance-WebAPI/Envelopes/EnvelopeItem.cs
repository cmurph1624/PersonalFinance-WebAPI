using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFinance_WebAPI.Envelopes
{
    public class EnvelopeItem
    {
        public int ID { get; set; }
        public string description { get; set; }
        public decimal amountBudgeted { get; set; }
        public decimal amountUsed { get; set; }
        public decimal amountRemaining { get; set; }
    }
}