using System;
using System.Threading;
using System.Threading.Tasks;
using CrewOnDemandCQRS.RequestModels.CommandRequestModels;
using CrewOnDemandCQRS.ResponseModels.CommandResponseModels;
using MediatR;

namespace CrewOnDemandCQRS.Handlers.CommandHandlers
{

    public class MakeBookingCommandHandler : IRequestHandler<MakeBookingRequestModel, MakeBookingResponseModel>
    {

        public async Task<MakeBookingResponseModel> Handle(MakeBookingRequestModel request, CancellationToken cancellationToken)
        {
            var result = new MakeBookingResponseModel
            {

                 IsSuccess = true,
                 BookingId = new Guid("43d26807-ad70-4449-8479-024c54eb2006")

        };

           return result;
        }
    }
}