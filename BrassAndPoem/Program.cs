
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using BrassAndPoem;

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType("Brass", 101),
    new ProductType("Poem", 102)
};

List<Product> products = new List<Product>()
{
    new Product("Where the Sidewalk Ends", 12.08M, productTypes.FirstOrDefault(p => p.Id == 102 )),
    new Product("The Raven", 15.20M, productTypes.FirstOrDefault(p => p.Id == 102 )),
    new Product("Trombone", 269.99M, productTypes.FirstOrDefault(p => p.Id == 101 )),
    new Product("Horn", 445.70M, productTypes.FirstOrDefault(p => p.Id == 101 )),
    new Product("Cornet", 220.26M, productTypes.FirstOrDefault(p => p.Id == 101 ))
};



//put your greeting here

//implement your loop here

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }