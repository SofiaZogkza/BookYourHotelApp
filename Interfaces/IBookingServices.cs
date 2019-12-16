using System;
using System.Collections.Generic;
using Types;

namespace Interfaces
{
    public interface IBookingServices
    {
        List<Response> Search(int HotelID, DateTime ArrivalDate);
    }
}
