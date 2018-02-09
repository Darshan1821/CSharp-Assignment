using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    class Question1
    {
        private static List<string> productList = new List<string>();

        public static void Question11()
        {
            InitializeProductList();

            var tomato = productList.FindAll(x => x.Equals("tomato",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Tomato Count (Case Insensitive): " + tomato.Count);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Indices of word Potato:");
            for (var i=0;i<productList.Count;i++)
            {
                if (productList[i].Equals("Potato", StringComparison.Ordinal)) Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        private static void InitializeProductList()
        {
            productList.Add("Tomato");
            productList.Add("Potato");
            productList.Add("ToMato");
            productList.Add("Potato");
            productList.Add("Red Tomato");
            productList.Add("Tomato Catchup");
            productList.Add("Grapes");
            productList.Add("grapes");
            productList.Add("potato");
        }
    }
}
