using System;
using System.Threading;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using CrewOnDemandCQRS.Controllers;
using CrewOnDemandCQRS.RequestModels.CommandRequestModels;
using CrewOnDemandCQRS.RequestModels.QueryRequestModels;
using CrewOnDemandCQRS.ResponseModels.CommandResponseModels;
using CrewOnDemandCQRS.ResponseModels.QueryResponseModels;
using Xunit;
using Assert = Xunit.Assert;

namespace CrewOnDemandCQRS.Testing
{
    public class BookingControllerTest
    {
        private Mock<IMediator> Mediator;
        public BookingControllerTest()
        {
            Mediator = new Mock<IMediator>();
        }

        [Fact]
        public void MakeBooking_Success_Result()
        {
            var makeBookingRequestModel = new MakeBookingRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<MakeBookingRequestModel>(), new CancellationToken())).
                ReturnsAsync(new MakeBookingResponseModel { IsSuccess = true, BookingId = Guid.NewGuid() });
            var bookingController = new BookingController(Mediator.Object);

            var result = bookingController.MakeBooking(makeBookingRequestModel);

            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        public void GetBookingById_Success_Result()
        {
            var getBookingByIdRequestModel = new GetBookingByIdRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<GetBookingByIdRequestModel>(), new CancellationToken())).
                ReturnsAsync(new GetBookingByIdResponseModel());
            var bookingController = new BookingController(Mediator.Object);

            var result = bookingController.BookingDetails(getBookingByIdRequestModel);

            Assert.IsType<OkObjectResult>(result);
        }
    }
}