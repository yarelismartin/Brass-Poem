//create your ProductType class here

namespace BrassAndPoem
{
    public class ProductType
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public ProductType(string title, int id)
        {
            Title = title;
            Id = id;
        }
    }

}