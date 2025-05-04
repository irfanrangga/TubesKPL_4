using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<Pengguna> users = new List<Pengguna>();
    }
}
