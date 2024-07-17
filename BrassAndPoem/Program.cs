
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


Console.WriteLine("Welcome to Bass and Poem Shop");
//put your greeting here

string choice = null;
//implement your loop here
while( choice != "5" )
{
    DisplayMenu();
    choice = Console.ReadLine();
    if ( choice == "1" )
    {
        DisplayAllProducts(products, productTypes);
    }
    else if ( choice == "2" )
    {
        DeleteProduct(products, productTypes);
    }
    else if ( choice == "3" ) 
    {
        AddProduct(products, productTypes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, productTypes);
    }
    else if (choice == "5")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Input. Please enter a number within range.");
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"Choose an Option:
        1. Display all products
        2. Delete a product
        3. Add a new product
        4. Update product properties
        5. Exit ");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        Console.WriteLine($"{i +1 }. {product.Name} is a {product.ProductTypeId.Title} priced at ${product.Price}. ");
    }
}

void DisplayAllProductTypes()
{
    for(int i = 0;i < productTypes.Count;i++) 
    {
        ProductType productType = productTypes[i];
        Console.WriteLine($"{i + 1}. {productType.Title}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the number of the product you would like to delete. ");
    DisplayAllProducts(products, productTypes);
    while(true)
        {
            if(int.TryParse(Console.ReadLine(), out int productIndex) && productIndex >= 1 && productIndex <= products.Count)
            {
                Console.WriteLine($"{products[productIndex -1]} has been deleted");
                products.RemoveAt(productIndex -1);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numbber within range. ");
            }
        }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Let's start by choosing a product type?");
    ProductType selectedProductType = CreateAndUpdateProductType();


    Console.WriteLine("What is the name of this product?");
    string selectedProductName = CreateAndUpdateProductName();

    Console.WriteLine("What is the price of this product.");
    decimal selectedPrice = CreateAndUpdateProductPrice();

    Product newProduct = new Product(selectedProductName, selectedPrice, selectedProductType);
    products.Add(newProduct);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Enter the number of the product you would like to update. ");

    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out int IndexOfProduct) && IndexOfProduct >= 1 && IndexOfProduct <= products.Count)
        {
            Product selectedProduct = products[IndexOfProduct - 1];


            Console.WriteLine($"The current product name is: {selectedProduct.Name}");
            Console.WriteLine("Enter the new product name. ");
            selectedProduct.Name = CreateAndUpdateProductName();


            Console.WriteLine($"The current price is ${selectedProduct.Price}");
            Console.WriteLine("What would you like the new price to be?");
            selectedProduct.Price = CreateAndUpdateProductPrice();

            Console.WriteLine($"The current Product Type is: {selectedProduct.ProductTypeId.Title}");
            Console.WriteLine("What would you like the new product type to be?");
            selectedProduct.ProductTypeId = CreateAndUpdateProductType();


            Console.WriteLine("Your product has be updated.");
            break;
        }
        else 
        {
            Console.WriteLine("Invalid input. Please enter a number within range of avilable products.");

        }
    }



}

string CreateAndUpdateProductName()
{
    string productName;
    while (true)
    {
        productName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(productName) && !productName.Any(char.IsDigit))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input please only eneter names. ");
        }
    }
    return productName;
}

decimal CreateAndUpdateProductPrice()
{
    decimal productPrice;
    while (true)
    {
        if (decimal.TryParse(Console.ReadLine(), out productPrice))
        {
            break;
        }
        else
        {
            Console.WriteLine("This is not a valid input.");
        }
    }
    return productPrice;
}

ProductType CreateAndUpdateProductType()
{
    ProductType productsProductType;
    DisplayAllProductTypes();
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int newProductTypeIndex) && newProductTypeIndex >= 1 && newProductTypeIndex <= productTypes.Count)
        {
            productsProductType = productTypes[newProductTypeIndex - 1];
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number within range of avilable product types.");
        }
    }
    return productsProductType;
}




// don't move or change this!
public partial class Program { }