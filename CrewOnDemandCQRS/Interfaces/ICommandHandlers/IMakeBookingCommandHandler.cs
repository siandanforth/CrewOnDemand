using CrewOnDemandCQRS.ResponseModels.CommandResponseModels;
using CrewOnDemandCQRS.RequestModels.CommandRequestModels;

namespace CrewOnDemandCQRS.Interfaces.ICommandHandlers
{
    public interface IMakeBookingCommandHandler
    {
        MakeBookingResponseModel MakeBooking(MakeBookingRequestModel requestModel);
    }
}
