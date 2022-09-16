using Car_Rental_Finder.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Car_Rental_Finder.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IcelandWRentalController : ControllerBase
{
    private readonly IIcelandWRService _carService;

        public IcelandWRentalController( IIcelandWRService carService)
        {
            _carService = carService;
        }

        // GET: api/cars
        [HttpGet]
        public IActionResult GetAllCars()
        {
            var carList = _carService.GetAllCars();
            if (!carList.Any())
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
        
        // GET: api/cars
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            _carService.AddCar(car);
            return Created("/", car);
        }
    
}