using API_JWT.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult> Register(UserCreateDTO userRegister)
        {
            return Ok();
        }

    }
}
