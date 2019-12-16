using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class RateTag
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "shape")]
        public bool Shape { get; set; }
    }
}
