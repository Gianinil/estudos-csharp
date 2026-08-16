using System;
using System.Globalization;

namespace ProdutosFormatacao
{
    class Progam
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"Computador, cujo preco é ${preco1:F2}");
            Console.WriteLine($"Mesa de escritorio, cujo preco é ${preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código: {codigo} e genero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}


