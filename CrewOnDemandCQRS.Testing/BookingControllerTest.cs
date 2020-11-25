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

            //Action
            var result = bookingController.MakeBooking(makeBookingRequestModel);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        public void GetBookingById_Success_Result()
        {
            var GetBookingByIdRequestModel = new GetBookingByIdRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<GetBookingByIdRequestModel>(), new CancellationToken())).
                ReturnsAsync(new GetBookingByIdResponseModel());
            var bookingController = new BookingController(Mediator.Object);

            //Action
            var result = bookingController.BookingDetails(GetBookingByIdRequestModel);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}