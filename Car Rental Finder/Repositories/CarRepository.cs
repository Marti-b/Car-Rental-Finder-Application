using Car_Rental_Finder.DataAccessLayer;
using Car_Rental_Finder.Models;
using Repositories.Interfaces;

namespace Repositories;

public class CarRepository : ICarRepository
{
    private readonly CarsContext Context;

    public CarRepository(CarsContext context)
    {
        Context = context;
    }
    
    public List<Car> GetAllCars( )
    {
        return Context.Cars.ToList();
    }
}