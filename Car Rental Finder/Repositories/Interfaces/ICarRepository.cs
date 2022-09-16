using Car_Rental_Finder.Models;

namespace Repositories.Interfaces;

public interface ICarRepository
{
    /// <summary>
    ///     Gets all the cars entites from database
    /// </summary>
    /// <returns> Returns a list of entites from the database</returns>
    List<Car> GetAllCars();
    
    void AddCar(Car car);

    Car GetCarById(int id);
}