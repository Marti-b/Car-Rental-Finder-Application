using Car_Rental_Finder.Models;

namespace Services.Interfaces;

public interface ICarService
{
    /// <summary>
    ///  Gets all the cars from the repository
    /// </summary>
    /// <returns> Returns list of cars from the repository </returns>
    List<Car> GetAllCars();
}