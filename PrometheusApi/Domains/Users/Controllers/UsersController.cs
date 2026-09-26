
using Microsoft.AspNetCore.Mvc;
using PrometheusApi.Domains.Users.Dtos;
using PrometheusApi.Domains.Users.Services;

namespace PrometheusApi.Domains.Users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDto dto)
        {
            
            var user = await _userService.CreateUser(dto.Name, dto.Email, dto.Password);
            var response = new UserResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };

            return Ok(response); // Placeholder response
        }
    }
}