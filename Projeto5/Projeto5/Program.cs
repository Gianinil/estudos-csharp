using System;

namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implícita
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a; //conversão explícita (cast)

            Console.WriteLine(b);

            c = (int)a; 
            Console.WriteLine(c); 

            int d = 5;
            int e = 2;

            double resultado = d / e; //divisão inteira, resultado = 2
            Console.WriteLine(resultado);

            resultado = (double) d / e;
            Console.WriteLine(resultado);
        }
    }
}