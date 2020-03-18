using Microsoft.AspNetCore.Mvc;
//自己加入
using BlogAPIDemo.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using BlogAPIDemo.Domain.Dtos;
using System;
using System.Security.Claims;
//加入套件
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;


namespace BlogAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly AppSettings _appSettings;

        public LoginController(IOptions<AppSettings> appSettings) 
        {
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserDto userDto) 
        {
            try {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    IssuedAt = DateTime.UtcNow,
                    NotBefore = DateTime.UtcNow,
                    Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, userDto.UserName)
                }),
                    Expires = DateTime.UtcNow.AddMinutes(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);
                return Ok(new
                {
                    UserName = userDto.UserName,
                    Token = tokenString
                });
            } catch (Exception ex) {
                return Ok(ex.ToString());
            }
     
        }
    }
}