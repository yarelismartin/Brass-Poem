//create your Product class here
namespace BrassAndPoem
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
        ProductType ProductTypeId { get; set; }
        public Product(string name, decimal price, ProductType productTypeId)
        {
            Name = name;
            Price = price;
            ProductTypeId = productTypeId;
        }
    }
}