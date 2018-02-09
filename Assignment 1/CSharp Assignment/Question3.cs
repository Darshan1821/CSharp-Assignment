using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CSharp_Assignment
{
    class Question3
    {
        private static Dictionary<string, PrimeMinister> pm = new Dictionary<string, PrimeMinister>();
            
        public static void Question13()
        {
            InitializeDictionary();

            Console.WriteLine("Prime Minister in 2004:\n");
            foreach (var p in pm.Values)
            {
                if (p.year.Equals("2004"))
                {
                    Console.WriteLine(p);
                    break;
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Added Current Prime Minister:\n");
            pm["NM"] = new PrimeMinister("Narendra Modi", "2014");
            foreach (var p in pm.Values) Console.WriteLine(p);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Read-Only Dictionary:\n");
            var pmRead = new ReadOnlyDictionary<string, PrimeMinister>(pm);
            foreach (var p in pmRead.Values) Console.WriteLine(p);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Sorted Dictionary:\n");
            pm = pm.OrderBy( y => y.Value.year).ToDictionary(t => t.Key , t => t.Value);
            foreach (var p in pm.Values) Console.WriteLine(p);
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        private static void InitializeDictionary()
        {
            pm.Add("ABV", new PrimeMinister("Atal Bihari Vajpayee","1998"));
            pm.Add("NM", new PrimeMinister("Narendra Modi", "2014"));
            pm.Add("MS", new PrimeMinister("Manmohan Singh", "2004"));
        }
    }
}
