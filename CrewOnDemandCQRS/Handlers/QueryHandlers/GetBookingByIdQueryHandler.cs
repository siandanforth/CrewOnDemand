using System.Threading;
using System.Threading.Tasks;
using CrewOnDemandCQRS.RequestModels.QueryRequestModels;
using CrewOnDemandCQRS.ResponseModels.QueryResponseModels;
using MediatR;

namespace CrewOnDemandCQRS.Handlers.QueryHandlers
{
    public class GetBookingByIdQueryHandler : IRequestHandler<GetBookingByIdRequestModel, GetBookingByIdResponseModel>
    {
        public async Task<GetBookingByIdResponseModel> Handle(GetBookingByIdRequestModel request, CancellationToken cancellationToken)
        {
            var bookingDetails = new GetBookingByIdResponseModel();

            return bookingDetails;
        }
    }
}
