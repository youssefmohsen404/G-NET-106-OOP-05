using G_NET106_OOP_02.part2;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_03
{
    internal class PriorityInternationalShipment: InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFees) : base(trackingCode, describtion, weight, deliveryFee, destinationCountry, customsFees)
        {
        }

        public sealed override void GenerateCustomReport()
        {
            base.GenerateCustomReport();
        }
        
    }
}
