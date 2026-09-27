using G_NET106_OOP_02.part2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | standard shipment | {shipment.Weight} kg| in transit";
        }
        public static bool IsDelivered(this Shipment shipment) {

            return false;
        }
    }
}
