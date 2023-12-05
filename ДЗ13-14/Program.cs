using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ13_14
{
    internal class Program
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Упражнение 13.1. Из класса банковский счет удалить методы, возвращающие значения полей номер счета и тип счета, заменить эти методы на свойства только для чтения.");
                Bank account = new Bank(12345, "Ivan Ivanov", 122334, 1832030);
                BankTransaction bankTransaction = new BankTransaction(DateTime.Now, "Пополнение");
                Console.WriteLine("Transaction Date: " + bankTransaction.Date);
                Console.WriteLine("Transaction Type: " + bankTransaction.Type);
                Console.WriteLine("Transaction Amount: " + bankTransaction.Amount);
                Console.WriteLine("Упражнение13.2");
                Bank account1 = new Bank(12345, "Ivan Ivanov", 122334, 1832030);
                account1.Refill(20);
                BankTransaction transaction1 = account1[0];
                Console.WriteLine("Упражнение 13.1: ");
                Building building1 = new Building(100, 10, 400, 8);
                Console.WriteLine("Высота одного этажа: " + building1.CalculateFloorHeight());
                Console.WriteLine("Квартир в подъезде: " + building1.CalculateApartmentsPerEntrance());
                Console.WriteLine("Квартир на этаже: " + building1.CalculateApartmentsPerFloor());
                Console.WriteLine("Упражнение13.2");
                _10Buildings1[0] = new Building(10, 3, 4, 20);
                _10Buildings1[1] = new Building(20, 3, 9, 10);
                Building buildings1 = _10Buildings[0];
                Building buildings2 = _10Buildings[1];

            }
        }
    }
}
