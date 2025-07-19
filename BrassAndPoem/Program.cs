
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



void DisplayMenu(List<Product> products, List<ProductType> types)
{
   
   
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine($@"
                         1. Display all products
                         2. Delete a product
                         3. Add a new product
                         4. Update product properties
                         5. Exit");
       choice = Console.ReadLine();
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
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
  
    ProductType brass = types.FirstOrDefault(x => x.Title == "Brass");
    ProductType poetry = types.FirstOrDefault(x => x.Title == "Poetry");

    
    
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].Name} for ${products[i].Price} is in the {(products[i].ProductTypeId == 1 ? brass.Title : poetry.Title)} category");
        }
    
    
}
void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Which product would you like to delete?");
    ProductType brass = types.FirstOrDefault(x => x.Title == "Brass");
    ProductType poetry = types.FirstOrDefault(x => x.Title == "Poetry");
    void RemoveProductDsiplay()
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].Name} for ${products[i].Price}" +
                $" in the {(products[i].ProductTypeId == 1 ? brass.Title : poetry.Title)} category");
        }
    }
        RemoveProductDsiplay();
        int choice = int.Parse(Console.ReadLine());
    for (int j = 0; j < products.Count; j++)
    {
        if (choice == products[j].productId)
        {
            products.RemoveAt(choice - 1);
            Console.WriteLine("Product removed!");
        }
    }
       
        void NewProductId()
        {
            for (int k = 0; k < products.Count; k++)
            {
                products[k].productId = k + 1;

            }
        }
        NewProductId();
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
    ProductType brass = types.FirstOrDefault(x => x.Title == "Brass");
    ProductType poetry = types.FirstOrDefault(x => x.Title == "Poetry");
    Console.WriteLine("Which product would you like to update?");
    void DisplayEdit()
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(@$"{i + 1}. {products[i].Name} for {products[i].Price} in the {(products[i].ProductTypeId == 1 ? brass.Title : poetry.Title)} category ");
        }
    }
    DisplayEdit();
    int editProduct = int.Parse(Console.ReadLine());
    for (int j =0; j < products.Count; j++)
    {
        if (editProduct == products[j].productId)
        {
            Console.WriteLine(@$"What would you like to edit:
                                1. Name: {products[j].Name}
                                2. Price: {products[j].Price}
                                3. Category: {(products[j].ProductTypeId == 1 ? brass.Title : poetry.Title)}");
            int userChange = int.Parse(Console.ReadLine());
            if (userChange == 1)
            {
                Console.WriteLine("Enter a new product name: ");
                string newName = Console.ReadLine();
                products[j].Name = newName;
                Console.WriteLine("New name added!");
            }
            else if (userChange == 2)
            {
                Console.WriteLine("Enter new product price: ");
                decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                products[j].Price = newPrice;
                Console.WriteLine("New price added!");
            }
            else if ( userChange == 3)

            {
                Console.WriteLine("Enter new product category: Enter 1 for Brass, 2 for Poetry");
                int newCat = int.Parse(Console.ReadLine());
                products[j].ProductTypeId = newCat;
                Console.WriteLine("New category added!");
            }
        }
    }
    
}



DisplayMenu(products, types);

// don't move or change this!
public partial class Program { }
