﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navy
{
    public class Transaction
    {
        public ObjectId Id { get; set; }

        public Operation TransactionType
        {
            get;
            set;
        }

        [BsonIndex]
        public DateTime Date { get; set; }

        public int Amount { get; set; }

        [BsonIndex]
        public string Security { get; set; }

        public string Description { get; set; }


        public Transaction()
        {
            TransactionType = Operation.Buy;
            Date = DateTime.Today;
            Amount = 0;
            Description = "";
        }
    }
}
