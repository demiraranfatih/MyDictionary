using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();

            myDictionary.Add("Red");
            myDictionary.Add("Yellow");
            myDictionary.Add("Pink");
            Console.WriteLine(myDictionary.Lengths);
            myDictionary.See();
        }
    }
}
