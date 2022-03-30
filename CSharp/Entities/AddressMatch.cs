
namespace Weather.Entities
{
    public class AddressMatch {
        public string matchedAddress { get; set; } = "";
        public Coordinates? coordinates { get; set; } = null;
        public TigerLine? tigerLine { get; set; } = null;
        public AddressComponents? addressComponents { get; set; }

    }
}
