using System;

namespace LinqDemo
{    
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product{Name="Apple",Category="Fruit",Price=5},
                new Product{Name="Pear",Category="Fruit",Price=5},
                new Product{Name="Carrot",Category="Vegetable",Price=3},
                new Product{Name="Zucchine",Category="Vegetable",Price=2},
            };

            //var groupedProducts = products.GroupBy(p => p.Category);

            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category:{group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"Product:{item.Name},Price:{item.Price}");
            //    }
            //}

            //var detailedGrouping = products.GroupBy(p => new { p.Category, p.Price }).ToList();
            //foreach (var group in detailedGrouping)
            //{
            //    Console.WriteLine($"Category:{group.Key.Category},Price:{group.Key.Price}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"Product:{item.Name}");
            //    }
            //}

            var detailedPrices = products.GroupBy(p => p.Category)
                .Select(group => new
                {
                    Category= group.Key,
                    AveragePrice=group.Average(product=>product.Price)
                });
            foreach (var group in detailedPrices)
            {
                Console.WriteLine($"Category:{group.Category},Average:{group.AveragePrice}");
            }
        }
    }
}