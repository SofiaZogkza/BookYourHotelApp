using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class HotelRates
    {
        [DataMember(Name = "adults")]
        public int Adults { get; set; }
        [DataMember(Name = "los")]
        public int Los { get; set; }
        [DataMember(Name = "price")]
        public Price Price { get; set; }
        [DataMember(Name = "rateDescription")]
        public string RateDescription { get; set; }
        [DataMember(Name = "rateID")]
        public int ID { get; set; }
        [DataMember(Name = "rateName")]
        public string RateName { get; set; }
        [DataMember(Name = "rateTags")]
        public List<RateTag> RateTags { get; set; }
        [DataMember(Name = "targetDay")]
        public DateTime TargetDay { get; set; }
    }
}
