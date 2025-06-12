using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlasanController : ControllerBase
    {
        public static List<Ulasan> ulasanList = new List<Ulasan>();
        private string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "SharedData", "DataJson", "DataUlasan.json");

        [HttpGet]
        public ActionResult<List<Ulasan>> GetAllUlasan()
        {
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string jsonData = System.IO.File.ReadAllText(filePath);
                    var data = JsonSerializer.Deserialize<List<Ulasan>>(jsonData);
                    ulasanList = data ?? new List<Ulasan>();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Error reading or parsing the file: {ex.Message}");
                }
            }
            else
            {
                return NotFound("Ulasan data file not found at: " + filePath);
            }
            return Ok(ulasanList);
        }

        [HttpGet("{id}")]
        public ActionResult<Ulasan> GetUlasanById(string id)
        {

            var ulasan = ulasanList.FirstOrDefault(u => u.ulasanId == id);
            if (ulasan == null)
            {
                return NotFound();
            }
            return Ok(ulasan);
        }
    }
}
