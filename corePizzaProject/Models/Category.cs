﻿namespace corePizzaProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CategoryAddedDate { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
