using Microsoft.AspNetCore.Mvc;
using WeatherForecastService.Controllers.Models;

namespace WeatherForecastService.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController: ControllerBase
    {
        private readonly WeatherForecastHolder _holder;
        public WeatherController(WeatherForecastHolder holder)
        {
            _holder = holder;
        }
        [HttpPost]
        public IActionResult Add([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            _holder.Add(date, temperatureC);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            _holder.Update(date, temperatureC);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] DateTime date)
        {
            _holder.Delete(date);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return Ok(_holder.Get(dateFrom, dateTo));
        }

    }
}
