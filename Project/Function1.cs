using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Function1
    {
        public static void main()
        {
            int a = 2;
            int b = 5;
            int s = 0, p = 0;
            Square(a, b, out s, out p);
            s.Print();
            p.Print();
        }

        static void Square(int a, int b,out int s,out int p)
        {
            s = a * b;
            p = 2*(a + b);
        }
    }
}
