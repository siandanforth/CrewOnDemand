using CrewOnDemandCQRS.RequestModels.QueryRequestModels;
using CrewOnDemandCQRS.ResponseModels.QueryResponseModels;

namespace CrewOnDemandCQRS.Interfaces.IQueryHandlers
{
    public interface IGetBookingByIdQueryHandler
    {
        GetBookingByIdResponseModel GetBookingById(GetBookingByIdRequestModel requestModel);

    }

}