using System;
using System.Collections.Generic;

namespace CSharp_Assignment
{
    class Question1
    {
        private static List<Product> productList = new List<Product>();

        public static void Question11()
        {
            InitializeProductList();

            Console.WriteLine("Total Products: " + productList.Count);
            Console.WriteLine("------------------------------------------------------------------------------");

            productList.Add(new Product("Potato", 10, 50, "Root"));
            Console.WriteLine("All Products:");
            PrintProducts(productList);
            Console.WriteLine("Total Products: " + productList.Count);
            Console.WriteLine("------------------------------------------------------------------------------");

            List<Product> product = productList.FindAll(p => p.type.ToLower() == "leafy green");
            Console.WriteLine("All Products which are leafy green:");
            PrintProducts(product);
            Console.WriteLine("------------------------------------------------------------------------------");

            productList.RemoveAll(p => p.name == "Garlic");
            Console.WriteLine("Total Products after removing garlic: " + productList.Count);
            Console.WriteLine("------------------------------------------------------------------------------");

            Product cabbage = productList.Find(p => p.name.ToLower() == "cabbage");
            Console.WriteLine("Total Cabbages: " + ( cabbage.quantity + 50 ));
            Console.WriteLine("------------------------------------------------------------------------------");

            double amount  = CalculateAmount();
            Console.WriteLine("Total Amount: "+amount);
        }

        private static void InitializeProductList()
        {
            productList.Add(new Product("Lettuce", 10.5, 50, "Leafy green"));
            productList.Add(new Product("Cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("Pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("Cauliflower", 10, 25, "Cruciferous"));
            productList.Add(new Product("Zucchini", 20.5, 50, "Marrow"));
            productList.Add(new Product("Yam", 30, 50, "Root"));
            productList.Add(new Product("Spinach", 10, 100, "Leafy green"));
            productList.Add(new Product("Broccoli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 50, "Leafy green"));
            productList.Add(new Product("Silverbeet", 10, 50, "Marrow"));
        }

        private static void PrintProducts(List<Product> productList)
        {
            Console.WriteLine("");
            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("");
        }

        private static double CalculateAmount()
        {
            double amt = 0;

            Product lettuce = productList.Find(p => p.name.ToLower() == "lettuce");
            Product zucchini = productList.Find(p => p.name.ToLower() == "zucchini");
            Product broccoli = productList.Find(p => p.name.ToLower() == "broccoli");

            amt = lettuce.price + (2 * zucchini.price) + broccoli.price;

            return amt;
        }

    }
}
