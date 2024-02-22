using System;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=2, ProductName= "Apple Telefon", QuantityPerUnit = "32 BG Ram", UnitPrice=60000, UnitInStock= 100 },
                new Product{ProductId=2, CategoryId=1, ProductName= "Lenovo Laptop", QuantityPerUnit = "64 BG Ram", UnitPrice=70000, UnitInStock= 200 },
                new Product{ProductId=3, CategoryId=1, ProductName= "Macbook Laptop", QuantityPerUnit = "64 BG Ram", UnitPrice=80000, UnitInStock= 30 },
                new Product{ProductId=4, CategoryId=2, ProductName= "A", QuantityPerUnit = "16 BG Ram", UnitPrice=45000, UnitInStock= 500 },
                new Product{ProductId=5, CategoryId=2, ProductName= "B", QuantityPerUnit = "16 BG Ram", UnitPrice=50000, UnitInStock= 0 },
            };


            Console.WriteLine("ALgoritmik--------------");
             foreach (var product in products)
            {
                if (product.UnitPrice > 50000 && product.UnitInStock >= 100)
                {
                    Console.WriteLine(product.ProductName);
                }
            }


            Console.WriteLine("Linq--------------------");

            var result = products.Where(p => p.UnitPrice > 50000 && p.UnitInStock >= 100);

            foreach (var product in result) 
            {
                Console.WriteLine(product.ProductName);
            }



        }



        
    }



    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }


    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}