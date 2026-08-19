using System;

namespace OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4 + 3 * 2;
            Console.WriteLine(n1);

            n1 = (4 + 3) * 2;
            Console.WriteLine(n1);

            int n2 = 17 % 3;
            Console.WriteLine(n2);

            double n3 = 10 / 8.0;
            Console.WriteLine(n3); // 1.25

            n3 = (double)10 / 8;
            Console.WriteLine(n3); // 1.25

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); 

            Console.WriteLine(x1);
            Console.WriteLine(delta); 


            
        }
    }
}