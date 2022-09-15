using Car_Rental_Finder.DataAccessLayer;
using Car_Rental_Finder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_Finder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        CarsContext _carsContext = new CarsContext();

        [HttpGet]
        public IEnumerable<CarEntity> Get()
        {
            return _carsContext.CarEntities;
        }
    }
}
