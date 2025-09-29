using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace InventoryManagement.Models.DTOs
{
    public class CreatePlaylistRequest
    {
        public string username { get; set; } = null!;
        [BsonElement("items")]
        [JsonPropertyName("items")]
        public List<string> movieIds { get; set; } = null!;
    }
}
