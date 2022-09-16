// using Car_Rental_Finder.Models;
// using Repositories.Interfaces;
// using Services.Interfaces;
//
// namespace Services;
//
// public class CarService : ICarService
// {
//     private readonly ICarRepository _carRepository;
//
//     public CarService( ICarRepository carRepository)
//     {
//         _carRepository = carRepository;
//     }
//     
//     public List<Car> GetAllCars()
//     {
//         return _carRepository.GetAllCars();
//     }
//
//     public void AddCar(Car car)
//     {
//         _carRepository.AddCar(car);
//     }
//
//     public int CalculateCost(int id)
//     {
//         var car = _carRepository.GetCarById(id);
//         return car.Price;
//     }
// }