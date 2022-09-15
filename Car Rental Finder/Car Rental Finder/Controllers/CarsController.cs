using Car_Rental_Finder.DataAccessLayer;
using Car_Rental_Finder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Car_Rental_Finder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        CarsContext _carsContext = new CarsContext();

        // GET: api/cars
        [HttpGet]
        public IActionResult GetAllCars(int categoryId)
        {
            var carsResult = _carsContext.Cars.Where(c => c.CategoryId == categoryId);
            if (carsResult == null)
                return NotFound();

            return Ok();
        }

        // GET: api/cars/getsortcars
        [HttpGet("[action]")]
        public IActionResult SortCars()
        {
            return Ok(_carsContext.Cars.OrderByDescending(c => c.Price));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            // if (car == null)
            // {
            //     return NoContent();
            // }
            _carsContext.Cars.Add(car);
            _carsContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}