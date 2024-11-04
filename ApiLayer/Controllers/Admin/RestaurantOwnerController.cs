using BusnessLayer.Abstraction;
using EntityLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ApiLayer.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantOwnerController : ControllerBase
    {
        private readonly IServiceRestaurantOwner _serviceRestaurantOwner;
        public RestaurantOwnerController(IServiceRestaurantOwner _serviceRestaurantOwner)
        {
            this._serviceRestaurantOwner = _serviceRestaurantOwner;
        }

        [HttpGet("RestaurantOwnerGetAll")]
        public async Task<IActionResult> GetAll()
        {
          var result = await _serviceRestaurantOwner.GetAll();
            return (result != null) ? Ok(result) : BadRequest();        
        }

        [HttpGet("RestaurantGetById{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _serviceRestaurantOwner.GetById(id);
            return (result != null) ? Ok(result) :  BadRequest();
        }

        [HttpPost("RestaurantOwnerAdd")]
        public async Task<IActionResult>Add(RestaurantOwner restaurantOwner)
        {
            var result = await _serviceRestaurantOwner.Add(restaurantOwner);
            return (result != null) ? Ok(result) : BadRequest();
        }

        [HttpDelete("RestaurantOwuner{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceRestaurantOwner.Delete(id);
            return (result != null) ? Ok(result) : BadRequest();
        }

        [HttpPut("RestaurantOwunerUpdate")]
        public async Task<IActionResult> Update(RestaurantOwner restaurantOwner)
        {
            var result = await _serviceRestaurantOwner.Update(restaurantOwner);
            return (result != null) ? Ok(result) : BadRequest();
        }




    }
}
