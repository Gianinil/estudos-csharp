using System;

namespace operadoresComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            bool b = a == 1;
            bool c = a != 1;
            bool d = a > 1;
            bool e = a < 1;
            bool f = a >= 1;
            bool g = a <= 1;

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}