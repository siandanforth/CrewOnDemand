using System;
using CrewOnDemandCQRS.ResponseModels.CommandResponseModels;
using MediatR;

namespace CrewOnDemandCQRS.RequestModels.CommandRequestModels
{
    public class MakeBookingRequestModel : IRequest<MakeBookingResponseModel>
    {
        public Guid BookingId { get; set; }
        public string BookingName { get; set; }
        public string BookingBase { get; set; }
        public DateTime Workdays { get; set; }

    }
}