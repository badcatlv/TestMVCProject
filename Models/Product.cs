using Microsoft.EntityFrameworkCore;

namespace EComMVCProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Precision(18,2)]
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;

        }

        public Product() { }


    }
}
