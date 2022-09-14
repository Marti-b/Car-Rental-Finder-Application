using Car_Rental_Finder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_Finder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private List<CarEntity> cars = new List<CarEntity>() {
            new CarEntity() {Id= Guid.NewGuid(), Brand = "Honda", Color= "blue", HorsePower = 189, Price = 50000, YearOfProduction = 1999}
        };

        [HttpGet]
        public IEnumerable<CarEntity> Get()
        {
            return cars;
        }
    }
}
