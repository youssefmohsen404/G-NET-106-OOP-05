using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class DeliveryAddress
    {
        public string city;
        public string street;
        public int buildingNumber;


        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"the city : {city} the street : {street} the building number:{buildingNumber}";
        }
        public override string ToString()
        {
            return $"the city : {city} the street : {street} the building number:{buildingNumber}";
        }
    }
}
