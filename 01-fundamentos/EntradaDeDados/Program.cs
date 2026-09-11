using System;
using System.Globalization;

namespace entradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"{a} {b} {c}");

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"{p1} {p2} {p3}");
        }
    }
}