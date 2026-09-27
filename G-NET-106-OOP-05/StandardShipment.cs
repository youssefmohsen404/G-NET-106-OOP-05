using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee) : base(trackingCode, describtion, weight, deliveryFee) {

        }
        public StandardShipment() {

        }
        public override decimal EstimatedCost
        {
            get {

                return base.EstimatedCost;
            }

        }
        //assignment 3 override
        public override void PrintShipment()
        {
            Console.WriteLine($"tracking code is:{TrackingCode} \n describtion is : {Describtion} \n weight :{Weight} \n delivery fee:{DeliveryFee} \n destination: {destination}");

        }

    }
  
    
    }
