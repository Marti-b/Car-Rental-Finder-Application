using Car_Rental_Finder.Models;

namespace Services.Interfaces;

public interface ISmartLRService
{
    /// <summary>
    ///  Gets all the cars from the repository
    /// </summary>
    /// <returns> Returns list of cars from the repository </returns>
    List<Car> GetAllCars();

    void AddCar(Car car);

    int CalculateDailyCost(int carId);
    
    Car GetCarById(int id);

    List<Car> GetCarsByBrandName(string brandName);

}