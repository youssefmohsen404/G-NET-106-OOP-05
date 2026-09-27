using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class ExpressShipment : Shipment
    {
        public ExpressShipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee, decimal extraFee) : base(trackingCode, describtion, weight, deliveryFee)
        {
            ExtraFee = extraFee;
        }
        public ExpressShipment() { }
        private decimal _extraFee;

        public decimal ExtraFee
        {
            get { return _extraFee; }

            set { if (value >= 0) {
                    _extraFee = value;
                }
                else
                {
                    Console.WriteLine("invalid extra fee");
                }

            }
        }
        //assignment 3 override
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5)+ ExtraFee;
            }

        }

        //assignment 3 override
        public override string ToString()
        {
            return base.ToString()+$"\n extra fees:{ExtraFee}";
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"tracking code is:{TrackingCode} \n describtion is : {Describtion} \n weight :{Weight} \n delivery fee:{DeliveryFee} \n destination: {destination}\n extra fee: {ExtraFee}");

        }
    }


    }

