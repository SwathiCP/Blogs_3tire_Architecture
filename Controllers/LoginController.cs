using Data_Access_Layer_DAL;
using Forms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Forms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly Business_Layer.BlogsAndRegisterBLL _BLL;

        public LoginController(Business_Layer.BlogsAndRegisterBLL _Bll)
        {
            _BLL = _Bll;
        }
        [HttpPost]
        public async Task<ActionResult<string>> CreateLogin(Login login)
        {
            return await _BLL.CreateLogin(login);
        }

    }
}
