using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navy
{
    public class Transaction
    {
        public Operation TransactionType
        {
            get;
            set;
        }

        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public string Security { get; set; }

        public string Description { get; set; }


        public Transaction(Operation transactionType)
        {
            TransactionType = transactionType;
            Date = DateTime.Today;
            Amount = 0;
            Description = "";
        }
    }
}
