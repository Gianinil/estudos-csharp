using System;
using System.Globalization;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um item:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesmo linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            
            Console.WriteLine("Dados da pessoa:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Último nome: " + lastName);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}