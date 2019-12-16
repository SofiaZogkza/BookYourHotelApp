using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class Price
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
        [DataMember(Name = "numericFloat")]
        public float NumericFloat { get; set; }
        [DataMember(Name = "numericInteger")]
        public int NumericInteger { get; set; }
    }
}
