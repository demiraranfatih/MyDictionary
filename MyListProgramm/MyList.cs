using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProgramm
{
    class MyList<F>
    {
        F[] dizi;
        public MyList()
        {
            dizi = new F[0];
        }
        public void Add(F fatih)
        {
            F[] refDizi = dizi;
            dizi = new F[dizi.Length + 1];
            for (int i = 0; i <refDizi.Length; i++)
            {
                dizi[i] = refDizi[i];
            }
            dizi[dizi.Length - 1] = fatih;

        }
        public void Goster()
        {
            foreach (F item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
