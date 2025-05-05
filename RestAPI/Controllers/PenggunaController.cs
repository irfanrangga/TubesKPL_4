using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PenggunaController : ControllerBase
    {
        private static List<Pengguna> users;
        private static string filePath = "TubesKPL/SharedData/DataJson/DataPengguna.json";

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
                    var data = JsonSerializer.Deserialize<List<Pengguna>>(jsonData);
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

        [HttpPost]
        public ActionResult<Pengguna> CreateUser([FromBody] Pengguna newUser)
        {
            if (newUser == null)
            {
                return BadRequest("Invalid user data.");
            }
            // Generate ID for the new user
            newUser.IdPengguna = newUser.Role == Pengguna.ROLEPENGGUNA.admin ? "A" : "P";
            users.Add(newUser);
            return CreatedAtAction(nameof(GetUserById), new { id = newUser.IdPengguna }, newUser);
        }
    }
}
