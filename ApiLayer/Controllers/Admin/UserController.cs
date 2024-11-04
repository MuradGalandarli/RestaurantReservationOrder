
using BusnessLayer.Abstraction;
using EntityLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceUser _serviceUser;

        public UserController(IServiceUser _serviceUser)
        {
            this._serviceUser = _serviceUser;
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(User user)
        {
            var data = await _serviceUser.Add(user);
            return (data != null) ? Ok(data) : BadRequest();
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var data = await _serviceUser.Update(user);
            return (data != null) ? Ok(data) : BadRequest(); 
        }

        [HttpGet("GetById")]
        public async Task<IActionResult>GetByIdUser(int id)
        {
            var data = await _serviceUser.GetById(id);
            return (data != null) ? Ok() : BadRequest();
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _serviceUser.Delete(id);
            return (data != null) ? Ok(data) : BadRequest();
        }

        [HttpGet("GetAllUser")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _serviceUser.GetAll();
            return (data != null) ? Ok(data) : NotFound();
        }


    }
}
