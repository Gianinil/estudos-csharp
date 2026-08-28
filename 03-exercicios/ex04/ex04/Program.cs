using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            Console.Write("nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            Console.Write("nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            } 
            else {
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            }


        }
    }
}