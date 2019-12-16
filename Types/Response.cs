using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "hotel")]
        public Hotel Hotels { get; set; }
        [DataMember(Name = "hotelRates")]
        public List<HotelRates> HotelRates { get; set; }
    }
}
