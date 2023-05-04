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
            MyDictionary<string,int> myDictionary = new MyDictionary<string,int>();

            myDictionary.Add("Value1", 1);
            myDictionary.Add("Value2", 2);
            myDictionary.Add("Value3", 3);
            myDictionary.Add("Value4", 4);
            myDictionary.See();

        }
    }
}
