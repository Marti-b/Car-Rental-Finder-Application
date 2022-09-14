using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Finder.Models
{
    public class CarEntity
    {
        [Key] public Guid Id { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public int HorsePower { get; set; }
        public int YearOfProduction { get; set; }
    }
}
