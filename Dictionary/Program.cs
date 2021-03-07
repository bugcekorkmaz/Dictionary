using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Table","Masa");
            myDictionary.Add("Pencil", "Kalem");
            myDictionary.Add("Chair", "Sandalye");
            Console.WriteLine(myDictionary.Length);
            Console.WriteLine("*******************");
            foreach (var item in myDictionary.Key)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************");
            foreach (var item in myDictionary.Value)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
