using System;
using System.Collections.Generic;

namespace CSharp_Assignment_3.Product
{
    public class ProductManagement
    {
        public static void ManageProducts()
        {
            ProductManager productManager = new ProductManager();

            AddProducts(productManager);
            DisplayMenu(productManager);
        }

        private static void DisplayMenu(ProductManager productManager)
        {
            int flag = 0;

            Console.WriteLine("\nActions:\n1. Classification based on type" +
                                      "\n2. Total price of whole inventory" +
                                      "\n3. Average price of all products" +
                                      "\n4. List costly products and cheap products" +
                                      "\n5. Exit");

            while (flag != 1)
            {
                Console.Write("\nEnter Action: ");
                try
                {
                    int action = int.Parse(Console.ReadLine());

                    switch (action)
                    {
                        case 1:
                            GetProductByCategory(productManager, "cruciferous");
                            GetProductByCategory(productManager, "leafy green");
                            GetProductByCategory(productManager, "marrow");
                            GetProductByCategory(productManager, "root");
                            break;
                        case 2:
                            Console.WriteLine("\nTotal Amount: " +
                                productManager.GetTotalAmountOfInventory() + " RS");
                            break;
                        case 3:
                            Console.WriteLine("\nAverage amount of products: " +
                                productManager.GetAverageAmountOfProducts() + " RS");
                            break;
                        case 4:
                            Console.WriteLine("\nCostly Products:");
                            productManager.PrintProducts(productManager.GetCostlyProducts(50));
                            Console.WriteLine("\nCheap Products:");
                            productManager.PrintProducts(productManager.GetCheapProducts(50));
                            break;
                        case 5:
                            flag = 1;
                            Console.WriteLine("\nProgram Finished.");
                            break;
                        default:
                            Console.WriteLine("Enter valid action!!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void GetProductByCategory(ProductManager productManager, string value)
        {
            List<Product> productByCategory = productManager.GetProductByCategory(value);

            if (productByCategory.Count != 0)
            {
                productManager.PrintProducts(productByCategory);
            }
            else
            {
                Console.WriteLine("No product with {0} value found.", value);
            }
        }

        private static void AddProducts(ProductManager productManager)
        {
            productManager.AddProduct("Lettuce", 10.5, 50, "Leafy Green");
            productManager.AddProduct("Cabbage", 20, 100, "Cruciferous");
            productManager.AddProduct("Pumpkin", 30, 30, "Marrow");
            productManager.AddProduct("Cauliflower", 10, 25, "Cruciferous");
            productManager.AddProduct("Zucchini", 20.5, 50, "Marrow");
            productManager.AddProduct("Yam", 30, 50, "Root");
            productManager.AddProduct("Spinach", 10, 100, "Leafy Green");
            productManager.AddProduct("Broccoli", 20.2, 75, "Cruciferous");
            productManager.AddProduct("Garlic", 30, 20, "Leafy Green");
            productManager.AddProduct("Silverbeet", 10, 50, "Marrow");
        }
    }
}
