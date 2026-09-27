using G_NET106_OOP_03;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET106_OOP_02.part2
{
    internal class DeliveryCenter
    {

        private Shipment[] shipment;
        public string centerName { get; set; }
        public Driver driver { get; set; }

        public int size { get; set; }
        public DeliveryCenter(int size )
        {
            shipment = new Shipment[size];
            
            
        }

        //        Returns the shipment at the given position. => give index to give shipment=> get
        //Allows replacing a shipment. => set
        //If the index is invalid, the getter returns default.
        //If the index is invalid while setting, do nothing.

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 || index < shipment.Length)
                    return shipment[index];
                return default;

            }
            set
            {
                if (index >= 0 || index < shipment.Length)
                    shipment[index] = value;

            }
        }


        //        Add a string indexer:
        //Returns the first shipment with the matching tracking code.
        //Returns default if no matching shipment is found.
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment s in shipment)
                {
                    if (s != null && s.TrackingCode == trackingCode)
                        return s;

                }
                return default;
            }

        }

        public bool AddShipment(Shipment s)
        {
            for (int i = 0; i < shipment.Length; i++)
            {

                if (shipment[i] == null)
                {
                    shipment[i] = s;
                    return true;
                }
            }
            return false;



        }

        //        Searches for a shipment using its tracking code.
        //If found:
        //Remove the shipment.
        //Return true.
        //Otherwise:
        //Return false.

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipment.Length; i++) {
                if (shipment[i] != null && shipment[i].TrackingCode == trackingCode)
                {
                    shipment[i] = null;
                    return true;
                }
                
            }
            return false;
        }
        public void PrintAllShipments()
        {
            foreach (Shipment s in shipment)
            {
                s.PrintShipment();
            }
            /* for (int i = 0; i < shipment.Length; i++)
             {
                 Console.WriteLine(shipment[i].PrintShipment);
             }*/

        }


    }




}

