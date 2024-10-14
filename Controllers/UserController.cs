using Microsoft.AspNetCore.Mvc;
using QLDD.Dtos.Response;
using QLDD.Services.Interface;

namespace QLDD.Controllers
{
    [ApiController]
    [Route("/api/v1/User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTORes>>> GetAll()
        {
            return Ok(await _userService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserDTORes>>> GetOne(int id)
        {
            return Ok(await _userService.GetById(id));
        }
    }
}
