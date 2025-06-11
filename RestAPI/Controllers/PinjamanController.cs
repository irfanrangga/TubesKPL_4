using ManajemenPerpus.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using ManajemenPerpus.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManajemenPerpus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PinjamanController : ControllerBase
    {
        private string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "SharedData", "DataJson", "DataPinjaman.json");
        private static List<FactoryBuku> listBuku = new List<FactoryBuku>();

        [HttpGet]
        public ActionResult<List<Pinjaman>> GetAllPinjaman()
        {
            if (System.IO.File.Exists(filePath)) {
                try
                {
                    string jsonData = System.IO.File.ReadAllText(filePath);
                    var data = JsonSerializer.Deserialize<List<Pinjaman>>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    });
                    if (data == null)
                    {
                        return Ok(new List<Pinjaman>());
                    }
                    return Ok(data);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Error reading or parsing the file: {ex.Message}");
                }
            }
            else
            {
                return NotFound("Pinjaman data file not found at: " + filePath);
            }
        }
    }
}
