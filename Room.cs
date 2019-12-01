using System;
using System.Collections.Generic;
using System.Text;

namespace Hausuebung1_Klassen
{
    class Room
    {
        private int number;
        private string roomType;
        private double roomVolume;
        private double roomArea;
        private double roomFireLoad;
        private double roomFireHazard;
        private List<FireDrencher> fireDrenchers;


        #region constructors
        public Room()
        {
            this.Number = 0;
            this.RoomType = "none";
            this.RoomVolume = 0.0;
            this.RoomFireLoad = 0.0;
            this.RoomFireHazard = 0.0;
            this.FireDrenchers = new List<FireDrencher>;
            this.RoomArea = 0.0;
        }

        public Room(int number, string roomType, double roomVolume, double roomFireLoad, double roomFireHazard, List<FireDrencher> fireDrenchers, double roomArea)
        {
            this.Number = number;
            this.RoomType = roomType;
            this.RoomVolume = roomVolume;
            this.RoomFireLoad = roomFireLoad;
            this.RoomFireHazard = roomFireHazard;
            this.FireDrenchers = fireDrenchers;
            this.RoomArea = roomArea;
        }
        #endregion

        //Start of Methods
        public double calculateFireDamage()
        {
            //Calculates the total potential Fire Damage
            double fireDamage = 0.0;
            //TODO fill in the right NUF into the if-statement
            if(this.RoomType == "1")
            {
                fireDamage = 390 * RoomArea;
            }
            else if(this.RoomType == "2")
            {
                fireDamage = 420 * roomArea;
            }
            else if (this.RoomType == "3")
            {
                fireDamage = 1200 * roomArea;
            }
            else if (this.RoomType == "4")
            {
                fireDamage = 800 * roomArea;
            }
            else if (this.RoomType == "5")
            {
                fireDamage = 285 * roomArea;
            }
            else if (this.RoomType == "6")
            {
                fireDamage = 230 * roomArea;
            }
            else if (this.RoomType == "7")
            {
                fireDamage = 555 * roomArea;
            }
            else
            {
                fireDamage = 0.0;
            }
            return fireDamage;
        }

        public int calculateFireDrenchers()
        {
            //Calculates the needed number of Fire-Drenchers for this room based on the fire damage
            // TODO: Number of fire drenchers erfragen und wie es aussieht, ob man ab nem Punkt meherere braucht
            int nrOfFireDrenchers = 0;

            return nrOfFireDrenchers;

        }


        //Start of Property-Methods
        #region propertyMethods
        public int Number { get => number; set => number = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public double RoomVolume { get => roomVolume; set => roomVolume = value; }
        public double RoomFireLoad { get => roomFireLoad; set => roomFireLoad = value; }
        public double RoomFireHazard { get => roomFireHazard; set => roomFireHazard = value; }
        internal List<FireDrencher> FireDrenchers { get => fireDrenchers; set => fireDrenchers = value; }
        public double RoomArea { get => roomArea; set => roomArea = value; }
        #endregion
    }
}
