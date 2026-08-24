using System;

namespace estruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            if (x > 9)
            {
                Console.WriteLine("Boa tarde!");
            }

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero é Par!");
            }

            else
            {
                Console.WriteLine("Numero é Impar!");
            }

            Console.WriteLine("Digite o horário");

            int horario = int.Parse(Console.ReadLine());

            if (horario < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if (horario < 18)
            {
                Console.WriteLine("Boa tarde!");
            }

            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}