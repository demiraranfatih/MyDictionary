using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> sayilarim = new MyList<int>();
            sayilarim.Add(1);
            sayilarim.Goster();
            sayilarim.Add(2);
            sayilarim.Goster();
            sayilarim.Add(3);
            sayilarim.Goster();
            sayilarim.Add(4);
            sayilarim.Goster();
            sayilarim.Add(5);
            sayilarim.Goster();

        }
    }
}
