using System;
using System.Collections.Generic;
using System.Text;

namespace Hausuebung1_Klassen
{
    class FireDrencher
    {
        double price;
        int capacity;
        string fireClass;

        public FireDrencher(double price, int capacity, string fireClass)
        {
            Price = price;
            Capacity = capacity;
            FireClass = fireClass;
        }

        #region propertyMethods
        public double Price { get => price; set => price = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string FireClass { get => fireClass; set => fireClass = value; }
        #endregion
    }
}
