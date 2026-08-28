using System;
using System.Threading.Channels;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("dados do funcionario 1: ");
            Console.Write("nome: ");
            f1.nome = Console.ReadLine();

            Console.Write("salario: ");
            f1.salario = double.Parse(Console.ReadLine());


            Console.WriteLine("dados do funcionario 2: ");
            Console.Write("nome: ");
            f2.nome = Console.ReadLine();

            Console.Write("salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine($"media dos salarios: {media:F2}");

        }
    }

}