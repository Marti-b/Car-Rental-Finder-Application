using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Finder.Models
{
    public class Car
    {
        [Key] 
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string ModelName { get; set; }
        public int HorsePower { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
        public int YearOfProduction { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  
    }
}
