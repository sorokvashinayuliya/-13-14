using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ13_14
{
    internal class Building
    {
        private static int lastBuildingNumber = 0;

        private int buildingNumber;
        private int height;
        private int floors;
        private int apartments;
        private int entrances;

        private int GenerateBuildingNumber()
        {
            lastBuildingNumber++;
            return lastBuildingNumber;

        }

        public int GetBuildingNumber
        {
            get { return buildingNumber; }
            set { buildingNumber = value; }
        }

        public int GetHeight
        {
            get { return height; }
            set { height = value; }
        }

        public int GetFloors
        {
            get { return floors; }
            set { floors = value; }
        }

        public int GetApartments
        {
            get { return apartments; }
            set { apartments = value; }
        }

        public int GetEntrances
        {
            get { return entrances; }
            set { entrances = value; }
        }

        public int CalculateFloorHeight()
        {
            return height / floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return apartments / (floors * entrances);
        }
        public Building(int height, int floors, int apartments, int entrances)
        {
            buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

    }
}
