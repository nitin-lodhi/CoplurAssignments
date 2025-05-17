using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserApiController : ControllerBase
    {
        IUserManager _userManager;
        public UserApiController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("allUsers")]
        public IActionResult GetAllUser()
        {
            var response = _userManager.GetAllUser();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var response = _userManager.GetUserById(id);
            if(response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }
    }
}