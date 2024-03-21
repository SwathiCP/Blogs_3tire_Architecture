using Forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly Business_Layer.BlogsAndRegisterBLL _BLL;

        public RegisterController(Business_Layer.BlogsAndRegisterBLL _Bll)
        {
            _BLL = _Bll;
        }


        [HttpGet]
        //[Route("GetUsers")]
        public async Task<ActionResult<IEnumerable<Register>>> GetUsers()
        {
            var users = await _BLL.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        //[Route("GetUsersById")]

        public async Task<ActionResult<IEnumerable<Register>>> GetUsersById(int id)
        {
            var uers = await _BLL.GetUsersById(id);
            if (uers == null)
            {
                return NotFound();

            }
            return Ok(uers);
        }


        [HttpPost]
        //[Route("CreateUser")]
        public async Task<ActionResult<Register>> CreateUser(Register register)
        {
            var users = await _BLL.CreateUser(register);
            return Ok(users);
        }
    }
}
