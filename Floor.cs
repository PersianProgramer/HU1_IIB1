using System;
using System.Collections.Generic;
using System.Text;

namespace Hausuebung1_Klassen
{
    class Floor
    {
        private int floorNumber;
        private double floorArea;
        private List<Room> rooms;

        #region constructors
        public Floor(int floorNumber, List<Room> rooms)
        {
            this.FloorNumber = floorNumber;
            this.Rooms = rooms;
            this.FloorArea = calculateFloorArea();
        }
        #endregion

        //Start of Methods
        public double calculateFloorArea()
        {
            double area = 0.0;
            foreach(Room room in Rooms)
            {
                area += room.RoomArea;
            }
            return area;
        }


        #region propertyMethods
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public double FloorArea { get => floorArea; set => floorArea = value; }
        internal List<Room> Rooms { get => rooms; set => rooms = value; }
        #endregion
    }
}
