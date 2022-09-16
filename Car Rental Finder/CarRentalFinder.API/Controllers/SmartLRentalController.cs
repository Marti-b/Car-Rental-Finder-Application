using Car_Rental_Finder.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Car_Rental_Finder.Controllers;

public class SmartLRentalController : ControllerBase
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ISmartLRService _carService;

        public CarsController(ISmartLRService carService)
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

        // GET: api/cars/search
        [HttpGet("Search")]
        public IActionResult GetSearchCars(string brandName)
        {
            var searchResult = _carService.GetCarsByBrandName(brandName);
            if (!searchResult.Any())
                return NotFound();

            return Ok(searchResult);
        }
        
        // Post: api/cars
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            _carService.AddCar(car);
            return Created("/", car);
        }
    }
}