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

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] Restaurant t)
        {
            var result = await _serviceRestorant.Addd(t);
            if(result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }



    }
}
