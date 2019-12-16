using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class Hotel
    {
        [DataMember(Name = "classification")]
        public int Classification { get; set; }
        [DataMember(Name = "hotelID")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "reviewscore")]
        public long ReviewScore { get; set; }
    }
}
