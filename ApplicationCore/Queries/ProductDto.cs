using ApplicationCore.Common;
using ApplicationCore.Entities;

namespace ApplicationCore.Queries
{
    public class ProductDto: IMapFrom<Product>
    { 
        public ProductDto(string Name, string Description, decimal Price)
        { 
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}