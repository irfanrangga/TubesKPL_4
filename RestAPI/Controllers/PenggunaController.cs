using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ManajemenPerpus.Core.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<Pengguna> users = new List<Pengguna>();


        [HttpGet]
        public ActionResult<List<Pengguna>> GetAllUsers()
        {
            // Gunakan path absolut relatif terhadap direktori kerja aplikasi
            string filePath = "TubesKPL/SharedData/DataJson/DataPengguna.json";

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string jsonData = System.IO.File.ReadAllText(filePath);
                    var data = System.Text.Json.JsonSerializer.Deserialize<List<Pengguna>>(jsonData);
                    users = data ?? new List<Pengguna>();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Error reading or parsing the file: {ex.Message}");
                }
            }
            else
            {
                return NotFound("User data file not found at: " + filePath);
            }

            return Ok(users);
        }


        [HttpGet("{id}")]
        public ActionResult<Pengguna> GetUserById(string id)
        {
            var user = users.FirstOrDefault(u => u.IdPengguna == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
