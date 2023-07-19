
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
using System.Linq;
string greeting = "Hello, Welcome to Brass & Poem shop!";
Console.WriteLine(greeting);

List<ProductType> productTypes = new List<ProductType>
{
    new ProductType {title = "Poem", id = 1},
    new ProductType { title = "Brass", id = 2},
};

List<Product> products = new List<Product>
{
    new Product { name = "poety book", productTypeId = 1, price = 4.99 },
    new Product { name = "trumpet", productTypeId = 2, price = 12.99 },
    new Product { name = "saxophone", productTypeId = 2, price = 14.99 },
    new Product { name = "flute", productTypeId = 2, price = 8.99 },
    new Product { name = "book of brass", productTypeId = 1, price = 2.99 },
};

int option;
do
{
    DisplayMenu();
    option = GetUserInput();
    switch (option)
    {
        case 1: DisplayAllProducts(products, productTypes); break;
        case 2: AddProduct(products, productTypes); break;
        case 3: UpdateProduct(products, productTypes); break;
        case 4: DeleteProduct(products, productTypes); break;
        case 5: Console.WriteLine("Thank you for using Brass & Poem. Goodbye!"); break;
    }
} while (option != 5);
static int GetUserInput()
{
    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        return choice;
    }
    return -1;
}

 void DisplayMenu()
{
    Console.WriteLine("-- Brass & Poem Menu --");
    Console.WriteLine("1. Display all products");
    Console.WriteLine("2. Add a new product");
    Console.WriteLine("3. Update a product");
    Console.WriteLine("4. Delete a product");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice (1-5): ");
}


void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\n-- All Products --");
    foreach (Product product in products)
    {
        string productTypeName = productTypes.FirstOrDefault(pt => pt.id == product.productTypeId)?.title;
        Console.WriteLine($"Name: {product.name}, Type: {productTypeName}, Price: ${product.price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\n-- Add New Product --");
    Console.WriteLine("Enter Product Name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter Product Price: ");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Product Type ID (1 = Poem & 2 = Brass): ");
    int productTypeId = int.Parse(Console.ReadLine());
    ProductType selectedProductType = productTypes.FirstOrDefault(pt => pt.id == productTypeId);
    if (selectedProductType == null)
    {
        Console.WriteLine("Invalid product type ID. Product not added.");
        return;
    }

    Product newProduct = new Product
    {
        name = name,
        price = price,
        productTypeId = productTypeId
    };

    products.Add(newProduct);


    Console.WriteLine("Product added successfully!");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\n-- Update Product --");
    Console.WriteLine("Select Product to Update: ");

    foreach (Product product in products)
    {
        string productTypeName = productTypes.FirstOrDefault(pt => pt.id == product.productTypeId)?.title;
        Console.WriteLine($"Name: {product.name}, Type: {productTypeName}, Price: ${product.price}");
    }
    int selectedProductId = int.Parse(Console.ReadLine());
    for (int i = 0; i < products.Count; i++) 
    {
        if (selectedProductId = products[i + 1]) 
        {
            Console.WriteLine(products[i]);
        }
    }

}

// don't move or change this!
public partial class Program { }