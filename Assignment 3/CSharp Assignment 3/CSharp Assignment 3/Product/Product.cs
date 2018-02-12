using System;

namespace CSharp_Assignment_3.Product
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-12} {1,-8} {2,-8} {3:-10}", Name, Price + " RS", Quantity, Type);
        }
    }
}
