using System;

namespace CSharp_Assignment
{
    class Product
    {
        public string name;
        public double price;
        public int quantity;
        public string type;
        public string format = "{0,-12}, {1,-10}, {2,-4}, {3,-10}";

        public Product(string name, double price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public override string ToString()
        {
            return String.Format(format,name,price + " RS", quantity,type); 
        }
    }
}
