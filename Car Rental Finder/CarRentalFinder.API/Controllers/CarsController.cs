using Car_Rental_Finder.DataAccessLayer;
using Car_Rental_Finder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Services.Interfaces;

namespace Car_Rental_Finder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController( ICarService carService)
        {
            _carService = carService;
        }

        // GET: api/cars
        [HttpGet]
        public IActionResult GetAllCars()
        {
            var carList = _carService.GetAllCars();
            if (carList == null)
                return NotFound();

            return Ok(carList);
        }

        // GET: api/cars/getsortcars
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            _carService.AddCar(car);
            return Created("/", car);
        }
    }
}