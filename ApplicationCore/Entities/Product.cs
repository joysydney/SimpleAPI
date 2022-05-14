using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; } 
        public Product(string name,
            string description,
            decimal price,
            int quantity,
            string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Image = image;
        }
    }
}
