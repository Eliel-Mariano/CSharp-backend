using Microsoft.AspNetCore.Mvc;
using TestCSharp.ControllersDTO;
using TestCSharp.Application.Services;
using TestBackendCSharp.Application.ViewModel;

namespace TestCSharp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<UserViewModel>> CreateUser(UserDTO userDto)
        {
            try
            {
                var user = await _userService.CreateUser(userDto);

                return Ok(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<UserViewModel>> UpdateUser(Guid id, UserDTO userDto)
        {
            try
            {
                var user = await _userService.UpdateUser(id, userDto);

                return Ok(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ActionResult<GetUserViewModel>> GetById(Guid id)
        {
            try
            {
                var user = await _userService.GetById(id);

                return Ok(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            try
            {
                await _userService.DeleteById(id);

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
