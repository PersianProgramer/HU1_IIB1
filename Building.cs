using System;
using System.Collections.Generic;
using System.Text;

namespace Hausuebung1_Klassen
{
    class Building
    {
        private string name;
        private double areaBuilding;
        private string address;
        private List<Floor> floors;

        public Building(string name, string address, List<Floor> floors)
        {
            Name = name;
            Address = address;
            Floors = floors;
            AreaBuilding = calculateAreaBuildung();
        }

        //Start of Methods
        public double calculateAreaBuildung()
        {
            //Calculates the area of the Building by adding the Floors together
            double area = 0.0;
            foreach(Floor floor in Floors)
            {
                area += floor.FloorArea;
            }
            return area;
        }

        #region propertyMethods
        public string Name { get => name; set => name = value; }
        public double AreaBuilding { get => areaBuilding; set => areaBuilding = value; }
        public string Address { get => address; set => address = value; }
        internal List<Floor> Floors { get => floors; set => floors = value; }
        #endregion
    }
}
