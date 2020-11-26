using System;

namespace CrewOnDemandCQRS.ResponseModels.QueryResponseModels
{
    public class GetBookingByIdResponseModel
    {
        public Guid BookingId { get; set; }
        public string BookingName { get; set; }
        public string BookingBase { get; set; }
        public DateTime Workdays { get; set; }
    }
}