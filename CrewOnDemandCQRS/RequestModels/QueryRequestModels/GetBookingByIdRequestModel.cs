using System;
using MediatR;
using CrewOnDemandCQRS.ResponseModels.QueryResponseModels;

namespace CrewOnDemandCQRS.RequestModels.QueryRequestModels
{
    public class GetBookingByIdRequestModel : IRequest<GetBookingByIdResponseModel>
    {
        public Guid BookingId { get; set; }
    }
}
