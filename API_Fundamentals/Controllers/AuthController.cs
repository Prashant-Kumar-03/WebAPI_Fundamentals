using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API_Fundamentals.Core.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace API_Fundamentals.Controllers
{
	[ApiController]
	[Route("api/Auth")]
	public class AuthController(IConfiguration config) : ControllerBase
	{
		[HttpPost("login")]
		public IActionResult Login([FromBody] LoginDto login)
		{
			// 1. Validate Credentials (In a real app, check your DB)
			if (login.Username == "admin" && login.Password == "password123")
			{
				var token = GenerateJwtToken(login.Username);
				return Ok(new { token });
			}

			return Unauthorized("Invalid username or password");
		}

		private string GenerateJwtToken(string username)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]!));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			// 2. Define Claims (User information stored in the token)
			var claims = new[]
			{
			new Claim(JwtRegisteredClaimNames.Sub, username),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
			new Claim(ClaimTypes.Role, "Admin")
		};

			// 3. Create the Token
			var token = new JwtSecurityToken(
				issuer: config["Jwt:Issuer"],
				audience: config["Jwt:Audience"],
				claims: claims,
				expires: DateTime.Now.AddHours(3),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
