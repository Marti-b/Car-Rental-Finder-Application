﻿namespace Car_Rental_Finder.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Car> Cars { get; set; }
}

