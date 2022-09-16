using Car_Rental_Finder.Models;
using Repositories.Interfaces;
using Services.Interfaces;

namespace Services;

public class IcelandWRService : IIcelandWRService
{
    private readonly ICarRepository _carRepository;
    
    public IcelandWRService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }
    public List<Car> GetAllCars()
    {
        return _carRepository.GetAllCars();
    }

    public void AddCar(Car car)
    {
        _carRepository.AddCar(car);
    }

    public int CalculateDailyCost(int carId)
    {
        var car = GetCarById(carId);
        
        // apply different calculation price based on temperature and wind
        var dailyPrice = car.Price;
            
        return dailyPrice;
    }

    public Car GetCarById(int id)
    {
        var car = _carRepository.GetCarById(id);
        return car;
    }

    public List<Car> GetCarsByBrandName(string brandName)
    {
        return _carRepository.GetCarsByBrandName(brandName);
    }
}