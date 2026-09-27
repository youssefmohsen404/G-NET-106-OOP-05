using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal partial class Shipment
    {
        private string TrackingStatus { get; set; } = "pending";
        partial void OnTrackingStatusChanged(string newStatus);

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }
        public void UpdateTrackingStatus(string trackingStatus)
        {
             //TrackingStatus = "Out For Delivery";
             TrackingStatus = trackingStatus;
            OnTrackingStatusChanged(TrackingStatus);
        }

        

    }
}
