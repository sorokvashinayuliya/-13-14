using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 14.1.");
            BankAccount account = new BankAccount(123442, "Ivan");
            account.DumpToScreen();
            Console.WriteLine("Упражнение 14.2.");
            Type type = typeof(RationalNumbers);
            DeveloperInfoAttribute attribute = (DeveloperInfoAttribute)Attribute.GetCustomAttribute(type, typeof(DeveloperInfoAttribute));
            Console.WriteLine($"Дата:{attribute.Date}");
            Console.WriteLine($"Разработчик:{attribute.Name}");
            Console.WriteLine("Упражнение 14.1.");
            Type type1 = typeof(BuildingDeveloperInfo);
            DeveloperInfoAttribute attribute1 = (DeveloperInfoAttribute)Attribute.GetCustomAttribute(type1, typeof(DeveloperInfoAttribute));
            Console.WriteLine($"Организация:{attribute1.OrganizationName}");
            Console.WriteLine($"Разработчик:{attribute1.Name}");

        }
    }
}
