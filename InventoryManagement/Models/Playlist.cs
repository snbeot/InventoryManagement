using InventoryManagement.Models.DTOs;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace InventoryManagement.Models
{
    public class Playlist
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string username { get; set; } = null!;
        [BsonElement("items")]
        [JsonPropertyName("items")]
        public List<string> movieIds { get; set; } = null!;

        public Playlist(CreatePlaylistRequest request)
        {
            username = request.username;
            movieIds = request.movieIds;
        }
    }
}
