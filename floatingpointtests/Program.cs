using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floatingpointtests
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            a = 1.345F;
            b = 1.123F;
            c = a + b;
            Console.WriteLine(string.Format("floats {0} + {1} == {2}: {3}", a, b, c, c == 2.468F));

            double d, e, f;
            d = .31D;
            e = .27D;
            f = d + e;
            Console.WriteLine(string.Format("doubles {0} + {1} == {2}: {3}", d, e, f, f == .58D));

            decimal g, h, i;
            g = 1.345M;
            h = 1.123M;
            i = g + h;
            Console.WriteLine(string.Format("decimals {0} + {1} == {2}: {3}", g, h, i, i == 2.468M));

            decimal j, k, l;
            j = .31M;
            k = .27M;
            l = j + k;
            Console.WriteLine(string.Format("decimals {0} + {1} == {2}: {3}", j, k, l, l == .58M));


            Console.ReadLine();
        }
    }
}
