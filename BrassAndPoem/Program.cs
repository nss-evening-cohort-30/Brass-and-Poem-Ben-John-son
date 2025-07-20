
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 120.99m,
        ProductTypeId = 1,
       productId = 1
    },
    new Product()
    {
        Name = "Trombone",
        Price = 150.99m,
        ProductTypeId = 1,
        productId = 2
    },
    new Product()
    {
        Name = "Saxophone",
        Price = 200.00m,
        ProductTypeId = 1,
        productId = 3
    },
    new Product()
    {
        Name = "Baritone Saxophone",
        Price = 4000.00m,
        ProductTypeId = 1,
        productId = 4
    },

    new Product()
    {
        Name = "Leaves of Grass",
        Price = 2.99m,
        ProductTypeId = 2,
        productId = 5
    },
    new Product()
    {
        Name = "The Waste Land",
        Price = 3.99m,
        ProductTypeId = 2,
        productId = 6
    },
    new Product()
    {
        Name = "The Divine Comedy",
        Price = 5.99m,
        ProductTypeId = 2,
        productId = 7
    },
    new Product()
    {
        Name = "Milk and Honey",
        Price = 6.99m,
        ProductTypeId = 2,
        productId = 8
    },
    new Product()
    {
        Name = "Howl",
        Price = 1.99m,
        ProductTypeId = 2,
        productId = 9
    }
};

List<ProductType> types = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1
    },
    new ProductType()
{
    Title = "Poetry",
    Id = 2
}
};




//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

//put your greeting here

//implement your loop here



void DisplayMenu()
{
    Console.WriteLine($@"1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}
DisplayMenu();

string choice = Console.ReadLine();

while (choice != "5")
{
    if (choice == "1")
    {
        DisplayAllProducts(products, types);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, types);
    }
    else if (choice == "3")
    {
        AddProduct(products, types);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, types);
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye");
    }
    Console.WriteLine();
     DisplayMenu();
    choice = Console.ReadLine();
}

   void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType type = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);

        string typeTitle = type != null ? type.Title : "Unknown";

        Console.WriteLine($"{i + 1}. {product.Name} for ${product.Price} is in the {typeTitle} category");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Which product would you like to delete?");
    for (int i = 0; i < products.Count; i++)
    {
        var type = productTypes.FirstOrDefault(t => t.Id == products[i].ProductTypeId);
        Console.WriteLine($"{i + 1}. {products[i].Name} for ${products[i].Price} in the {type?.Title ?? "Unknown"} category");
    }
    int choice = int.Parse(Console.ReadLine());
    if (choice >= 1 && choice <= products.Count)
    {
        products.RemoveAt(choice - 1);
        Console.WriteLine("Product removed!");
    }
}



void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please fill out the information for the new product");
    Console.WriteLine("Product name:");
    string newName = Console.ReadLine();
    Console.WriteLine("Product price");
    decimal productPrice = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine(@"Product category: 
                        1. Brass
                        2. Poetry");
    int categoryId = int.Parse(Console.ReadLine());
    int addId = products.Count + 1;
    Product newProduct = new Product
    {
        Name = newName,
        Price = productPrice,
        ProductTypeId = categoryId,
        productId = addId
    };
    products.Add(newProduct);
    Console.WriteLine("New product Added!");
    
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Which product would you like to update?");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name} for ${products[i].Price} in the {productTypes.FirstOrDefault(pt => pt.Id == products[i].ProductTypeId).Title} category");
    }

    int editIndex = int.Parse(Console.ReadLine()) - 1;

    if (editIndex >= 0 && editIndex < products.Count)
    {
        Console.WriteLine("Enter a new product name:");
        string newName = Console.ReadLine();

        // Only update the name
        products[editIndex].Name = newName;

        Console.WriteLine("New name added!");
    }
}





// don't move or change this!
public partial class Program { }
