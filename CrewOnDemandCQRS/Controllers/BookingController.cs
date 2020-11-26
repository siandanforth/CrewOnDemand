using CrewOnDemandCQRS.RequestModels.QueryRequestModels;
using CrewOnDemandCQRS.RequestModels.CommandRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult MakeBooking([FromBody] MakeBookingRequestModel requestModel)
        {
            var response  = _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("booking")]
        public IActionResult BookingDetails([FromQuery] GetBookingByIdRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
