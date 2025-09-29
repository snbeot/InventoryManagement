using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class PlaylistController: Controller
    {
        private readonly MongoDBService _mongoDBService;
        [HttpGet]
        public async Task<List<Playlist>> Get()
        {
            return await _mongoDBService.GetAsync();
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Playlist playlist)
        {
            await _mongoDBService.CreateAsync(playlist);
            return CreatedAtAction(nameof(Get), new { id = playlist.Id }, playlist);
        }
        [HttpPut("id")]
        public async Task<IActionResult> AddToPlaylist(string id, [FromBody] string movieId)
        {
            await _mongoDBService.AddTpPlaylistAsync(id, movieId);
            return NoContent();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(String id)
        {
            await _mongoDBService.DeleteAsync(id);
            return NoContent();
        }

    }
}
