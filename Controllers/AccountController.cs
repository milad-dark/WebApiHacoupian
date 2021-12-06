using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WepApiHacoupian.Extention;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.ViewModel;

namespace WepApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IConfiguration _configuration;
        private readonly IPerson _user;

        public AccountController(IConfiguration configuration, IPerson user)
        {
            _configuration = configuration;
            _user = user;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserViewModel.UserModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var getUser = await _user.Login(model.UserName, model.Password);

                    if (getUser)
                    {
                        var tokenResualt = new JWTTokenGenerator(_configuration.GetValue<string>("secret")).GeneratorToken(model.UserName, model.Password);

                        return Ok(new { token = tokenResualt });
                    }
                }
                catch (System.Exception ex)
                {

                    return BadRequest(ex.InnerException + "\n" + ex.Message);
                }

            }
            return BadRequest("نام کاربری و رمز عبور اشتباه است");
        }

    }
}
