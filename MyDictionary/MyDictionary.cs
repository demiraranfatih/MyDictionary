using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<I,T>
    {
        T[] tKey;
        I[] vKey;
        public MyDictionary()
        {
            tKey = new T[0];
            vKey = new I[0];
        }
        public void Add(I values , T key )
        {
            T[] tArray = tKey;
            I[] vArray = vKey;
            tKey = new T[tKey.Length+1];
            vKey = new I[vKey.Length + 1];
            for (int i = 0; i <tArray.Length; i++)
            {
                tKey[i] = tArray[i];
                vKey[i] = vArray[i];
            }
            tKey[tKey.Length- 1] = key;
            vKey[vKey.Length - 1] = values;
        }
        public void See()
        {
            for (int i = 0; i <tKey.Length; i++)
            {
                Console.WriteLine(tKey[i]+" : "+vKey[i]);
            }
        }
    }
}
