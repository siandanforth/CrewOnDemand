using System;
namespace CrewOnDemandCQRS.ResponseModels.CommandResponseModels
{
    public class MakeBookingResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid BookingId { get; set; }
    }
} 