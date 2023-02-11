using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskAssignmentApplication.Models;

namespace TaskAssignmentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public async Task<bool> LoginAsync(UserCredentials userCredentials)
        {
            return true;
        }
    }
}
