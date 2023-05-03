using System;

namespace LINQExercise
{

    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        
    }
    internal class Program
    {
        static void SeedData(List<Product> products)

        {
            products.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            products.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            products.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            products.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            products.Add(new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 });
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            SeedData(products);

            var item = products.Where(p => p.Price >=20000&& p.Price<=40000).ToList();
            Console.WriteLine("\nProducts within 20k to 40");
            foreach (Product p in item)
            {    
                Console.WriteLine(p.ProductName);

            }
            var alpha = products.Where(p => p.ProductName.Contains("a"));
            Console.WriteLine("\nProducts containing letter 'a'");
            foreach(Product p in alpha)
            {
                Console.WriteLine(p.ProductName);
            }
            var sort=products.OrderBy(p => p.ProductName).ToList();
            Console.WriteLine("\nProducts sorted alphabatically:");
            foreach(Product p in sort)
            {
                Console.WriteLine(p.ProductName);
            }

            var Max = products.Max(p => p.Price);
            Console.WriteLine("\nHighest Price: " + Max);

            var ProductPresent= products.Any(p => p.ProductId == "P003");
            Console.WriteLine("\nWhether the  Product with ProductId P003 exist: " + ProductPresent);
        }
 
    }
}

