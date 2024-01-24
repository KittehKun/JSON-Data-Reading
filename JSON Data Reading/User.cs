using System.Text.Json.Serialization;

namespace JSON_Data_Reading
{
    internal class User
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        public override string ToString()
        {
            return
                $"Username: {Username}" +
                $"\nName: {Name}" +
                $"\nAge: {Age}" +
                $"\nEmail: {Email}" +
                $"\nAddress: {Address}\n\n";
        }
    }
}
