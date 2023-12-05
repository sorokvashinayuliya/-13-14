using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ13_14
{
    internal class BankTransaction
    {

        private DateTime date;
        private double amount;
        private string type;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public BankTransaction(double amount, string type)
        {
            Amount = amount;
            Type = type;
            this.amount = amount;
            this.type = type;
        }


    }
}
