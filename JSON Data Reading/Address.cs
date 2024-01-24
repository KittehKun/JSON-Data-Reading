using System.Text.Json.Serialization;

namespace JSON_Data_Reading
{
    internal class Address
    {
        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        public override string ToString()
        {
            return
                $"\n\tCity: {City}" +
                $"\n\tState: {State}" +
                $"\n\tCountry: {Country}";
        }
    }
}
