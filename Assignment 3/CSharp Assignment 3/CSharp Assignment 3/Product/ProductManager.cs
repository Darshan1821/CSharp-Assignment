using System;
using System.Collections.Generic;

namespace CSharp_Assignment_3.Product
{
    public class ProductManager
    {
        public ProductManager()
        {
            _productList = new List<Product>();
        }

        public void AddProduct(string name, double price, int quantity, string type)
        {
            _productList.Add(new Product() { Name = name, Price = price, Quantity = quantity, Type = type });
        }

        public List<Product> GetProductByCategory(string type)
        {
            return _productList.FindAll(p => p.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        public double GetTotalAmountOfInventory()
        {
            double amount = 0;

            foreach (var p in _productList)
            {
                amount += (p.Price * p.Quantity);
            }

            return amount;
        }

        public double GetAverageAmountOfProducts()
        {
            double averageAmount = 0;

            foreach (var p in _productList)
            {
                averageAmount += p.Price;
            }

            averageAmount /= 10;

            return averageAmount;
        }

        public List<Product> GetCostlyProducts(double price)
        {
            return _productList.FindAll(p => p.Price > 50);
        }

        public List<Product> GetCheapProducts(double price)
        {
            return _productList.FindAll(p => p.Price <= 50);
        }

        public void PrintProducts(List<Product> productList)
        {
            if (productList.Count != 0)
            {
                Console.WriteLine(String.Format("\n{0,-12} {1,-8} {2,-8} {3:-10}\n", "Name", "Price", "Quantity", "Type"));
                foreach (var product in productList) Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("\nNo products found.");
            }
        }

        List<Product> _productList;
    }
}
