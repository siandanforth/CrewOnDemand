using CrewOnDemandCQRS.ResponseModels.CommandResponseModels;

namespace CrewOnDemandCQRS.Interfaces.ICommandHandlers
{
    public interface IMakeBookingCommandHandler
    {
        MakeBookingResponseModel MakeBooking(MakeBookingResponseModel requestModel);
    }
}
