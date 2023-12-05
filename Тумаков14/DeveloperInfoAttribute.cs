using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public object OrganizationName { get; internal set; }

        public DeveloperInfoAttribute(string name, string date)
        {
            Name = name;
            Date = date;

        }
    }
}
