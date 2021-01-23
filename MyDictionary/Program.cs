using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "SIFIR");
            
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "SIFIR");
        }
    }
}
