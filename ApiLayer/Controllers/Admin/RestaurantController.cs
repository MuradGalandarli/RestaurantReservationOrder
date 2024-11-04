using BusnessLayer.Abstraction;
using EntityLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ApiLayer.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IServiceRestorant _serviceRestorant;

        public RestaurantController(IServiceRestorant _serviceRestorant)
        {
            this._serviceRestorant = _serviceRestorant;
        }

        [HttpPost("AddRestaurant")]
        public async Task<IActionResult> Add([FromBody] Restaurant t)
        {
            var result = await _serviceRestorant.Add(t);
            return (result != null) ? Ok(result) : BadRequest();
        }

        [HttpPut("UpdateRestaurant")]
        public async Task<IActionResult> Update(Restaurant restaurant)
        {
            var result = await _serviceRestorant.Update(restaurant);
            return (result != null) ? Ok(result) : BadRequest();
        }

        [HttpGet("GetByIdRestaurant{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _serviceRestorant.GetById(id);
            return (data != null) ? Ok(data) : BadRequest();
        }
        [HttpDelete("DeleteRestaurant{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceRestorant.Delete(id);
            return (result != null) ? Ok(result) : BadRequest();
        }
        [HttpGet("GetAllRestaurand")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _serviceRestorant.GetAll();
            return (result != null) ? Ok(result) : BadRequest();
        }





    }
}
