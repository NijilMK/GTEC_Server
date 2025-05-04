using DataAccessLayer.General.Masters;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyWeb.Data;
using Repository;
using System.Security.Claims;
using System.Text;

namespace MyWeb.Controllers
{
    // API Controller (example)
    [ApiController]   
    [Route("[controller]")]
    [Authorize]
    public class AuthController : ControllerBase
    {
        string errorMessage = "Invalid username or password";
        private IGenericBaseRepository<User> _repository;

        public AuthController(IGenericBaseRepository<User> repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin credentials)
        {
            //// Validate credentials
            //if (credentials.Name == credentials.Name && credentials.Password == credentials.Password)
            //{
            //    // Generate JWT token
            //    var token = GenerateJwtToken(credentials.Name, "your_issuer", "your_audience");

            //    return Ok(new { Token = token });
            //}

            //return Unauthorized();

            ResponseViewModel returnObject = new ResponseViewModel();
            var user = _repository.Filter(x => x.UserName == credentials.UserName).FirstOrDefault();
            if (user != null)
            {
                //string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: dto.Password, salt: user.Salt, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8));

                //if (hashed == user.Password)
                if(credentials.UserName == user.UserName)
                {
                    returnObject.Success = true;
                    returnObject.Message = "Login Success";
                    returnObject.Data = user;
                }
                else
                {
                    returnObject.Success = false;
                    returnObject.Message = errorMessage;
                }
            }
            else
            {
                returnObject.Success = false;
                returnObject.Message = errorMessage;
            }

            return Ok(returnObject);

        }



        //// Protected API endpoint
        //[HttpGet("secure")]
        //[Authorize]
        //public IActionResult Secure()
        //{
        //    return Ok("This is a secure endpoint!");
        //}

        private string GenerateJwtToken(string username, string issuer, string audience)
        {
            return "659476889604ib26is5ods8ah9l";
            //var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            ////var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my custom Secret key for authentication"));
            //var key = Encoding.UTF8.GetBytes("this is my custom Secret key for authentication for JWT Toekn");
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new[] { new Claim("username", username) }),
            //    Expires = DateTime.Now.AddHours(1),
            //    Issuer = issuer,
            //    Audience = audience,
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //return tokenHandler.WriteToken(token);
        }
    }
}
