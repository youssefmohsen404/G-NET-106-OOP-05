using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_03
{
    internal class Driver
    {
        public Driver(int driverId, string fullName, int phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public int DriverId { get; set; }
        public string FullName{ get; set; }
        public int PhoneNumber{ get; set; }
    }
}
