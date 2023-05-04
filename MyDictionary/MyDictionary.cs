using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] dictionary;
        public MyDictionary()
        {
            dictionary = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = dictionary;
            dictionary = new T[dictionary.Length+1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                dictionary[i] = tempArray[i];
            }
            dictionary[dictionary.Length- 1] = item;
        }
        public void See()
        {
            foreach (T x in dictionary)
            {
                Console.WriteLine(x);
            }
        }
       public int Lengths
        {
            get { return dictionary.Length; }
        }
    }
}
