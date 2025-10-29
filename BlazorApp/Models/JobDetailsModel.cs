using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BlazorApp.Models
{
    public class JobDetailsModel
    {
        [Required(ErrorMessage = "Job ID is required.")]
        public string JobId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Client Name is required.")]
        public string ClientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Consignee Name is required.")]
        public string ConsigneeName { get; set; } = string.Empty;

        [Required(ErrorMessage = "ETA is required.")]
        [DataType(DataType.Date)]
        public DateTime? ETA { get; set; }

        [Required(ErrorMessage = "ETD is required.")]
        [DataType(DataType.Date)]
        public DateTime? ETD { get; set; }

        [Required(ErrorMessage = "Pickup Location is required.")]
        public string PickupLocation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Delivery Location is required.")]
        public string DeliveryLocation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a status.")]
        public string CurrentStatus { get; set; } = string.Empty;

        public List<string> StatusSteps { get; set; } = new()
        {
            "Shipment Confirmation",
            "Cargo Received",
            "In Transit",
            "Arrival at Destination",
            "Customs Clearance Complete",
            "Arrival at Destination Hub",
            "Out for Delivery",
            "Delay Notification",
            "Delivery Confirmation",
            "Feedback/NPS"
        };
    }
}
