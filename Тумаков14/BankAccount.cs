using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков14
{
    internal class BankAccount
    {
        private int number;
        private string name;
        private int Number
        {
            get { return number; }
            set { number = value; }
        }
        private string Name
        {
            get { return name; }
            set { name = value; }
        }
        public BankAccount(int number, string name)
        {
            this.name = name;
            this.number = number;
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("Номер:" + number);
            Console.WriteLine("Владелец:" + name);
        }


    }
}
