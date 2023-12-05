using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class BuildingDeveloperInfo : Attribute
    {
        public string Name { get; set; }

        public string OrganizationName { get; set; }
        public BuildingDeveloperInfo(string name, string organizationName)
        {
            Name = name;
            OrganizationName = organizationName;
        }
    }
}
