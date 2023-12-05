using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ13_14
{
    internal class _10Buildings
    {
        private Building[] buildings;
        public _10Buildings()
        {
            buildings = new Building[10];

        }
        public Building this[int index]
        {
            get { return buildings[index]; }
            set { buildings[index] = value; }
        }
    }
}
