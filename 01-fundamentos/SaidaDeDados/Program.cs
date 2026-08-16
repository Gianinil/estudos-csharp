using System;
using System.Collections.Generic;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "Maria";
            char genero = 'F';
            double saldo = 23.50321;

            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa tarde!");
            Console.Write("Boa noite!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine($"{nome} do genero {genero} tem o valor de {saldo.ToString("F2")} no banco" );
            Console.WriteLine("{0} do genero {1} tem o valor de {2} no banco", nome, genero, saldo.ToString("F2"));
        }
    }
}