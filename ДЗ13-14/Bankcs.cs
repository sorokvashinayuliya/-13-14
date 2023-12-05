using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ13_14
{
    internal class Bank
    {
        internal class Bank
        {
            private int number;
            private string name;
            private int _id;
            private double balance;
            private Queue<BankTransaction> transactions;
            private List<BankTransaction> transactions1;
            public int ID
            {
                get { return _id; }
                set { _id = value; }
            }
            public double Balance
            {
                get { return balance; }
                set { balance = value; }
            }
            private int Number
            {
                get { return number; }
                set { number = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Bank(int number, string name, int _id, double balance)
            {
                this.number = number;
                this.name = name;
                this._id = _id;
                this.balance = balance;
                transactions = new Queue<BankTransaction>();


            }

            public void Refill(int amount)
            {
                balance += amount;
                BankTransaction transaction = new BankTransaction(balance, "Пополнение");
                transactions.Enqueue(transaction);
            }
            public void Withdrawal(int amount)
            {
                balance -= amount;
                BankTransaction transaction = new BankTransaction(balance, "Снятие");
                transactions.Enqueue(transaction);
            }

            public BankTransaction this[int index]
            {
                get { return transactions1[index]; }
                set { transactions1[index] = value; }
            }

        }
    }
}
