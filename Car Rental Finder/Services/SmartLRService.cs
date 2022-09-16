using Car_Rental_Finder.Models;
using Repositories.Interfaces;

namespace Services.Interfaces;

public class SmartLRService : ICarService
{
    private readonly ICarRepository _carRepository;

    public SmartLRService(ICarRepository carRepository)
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

    public int CalculateCost(int id)
    {
        var car = _carRepository.GetCarById(id);
        
        // apply different calculation price based on weight, color and number of horsepower
        var dailyPrice = car.Price;
            
        return dailyPrice;
    }
}