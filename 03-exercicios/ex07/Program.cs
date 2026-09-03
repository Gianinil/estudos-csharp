using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto");

            Total t = new Total();
            
            
            Console.Write("Nome: ");
            t.Nome = Console.ReadLine();
            
            Console.Write("Preco: ");
            t.Preco = double.Parse(Console.ReadLine());
            
            Console.Write("Quantidade em estoque: ");
            t.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nome: " + t);
            
            Console.WriteLine("Digite o numero de produtos que deseja Adicionar: ");
            int qtd = int.Parse(Console.ReadLine());
            t.Adicao(qtd);
            Console.WriteLine($"Dados atualizados: " + t);
            
            Console.WriteLine("Digite o numero de produtos que deseja Remover: ");
            int qtd2 = int.Parse(Console.ReadLine());
            t.Subtracao(qtd2);
            Console.WriteLine($"Dados atualizados: " + t);
        }
    }
}