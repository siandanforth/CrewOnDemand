using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CrewOnDemandCQRS.RequestModels.QueryRequestModels;
using CrewOnDemandCQRS.RequestModels.CommandRequestModels;

namespace CrewOnDemandCQRS.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IMediator _mediator;

        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("makebooking")]

        public IAsyncResult MakeBooking([FromBody] MakeBookingRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel);
            return (IAsyncResult)Ok(response);
        }

        [HttpGet("booking")]
        public IAsyncResult BookingDetails([FromQuery] GetBookingByIdRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel);
            return (IAsyncResult)Ok(response);
        }
    }
}
