using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Types;

namespace BookYourHotel.Controllers
{
    [RoutePrefix("api/hotel")]
    public class HotelController : ApiController
    {
        private IBookingServices bookingService;

        public HotelController(IBookingServices bookingService)
        {
            this.bookingService = bookingService;
        }

        [HttpGet]
        [Route("getsearch/{HotelID}/{ArrivalDate}")]
        public List<Response> GetSearch(int HotelID, DateTime ArrivalDate )
        {
            //DateTime ArrivalDate = new DateTime();
            var result = bookingService.Search(HotelID, ArrivalDate);
            return result;
        }
    }
}
