using System.Text.Json.Serialization;

namespace Car3TierSystem_1stTier.Models
{
    public class Car
    {
        [JsonPropertyName("license_plate")]
        public string LicensePlate { get; set; }
        
        [JsonPropertyName("brand")]
        public string Brand { get; set; }
        
        [JsonPropertyName("model")]
        public string Model { get; set; }
        
        [JsonPropertyName("power")]
        public int Power { get; set; }
    }
}