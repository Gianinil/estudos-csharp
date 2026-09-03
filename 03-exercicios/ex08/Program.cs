using System;
namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotacao do Dollar atualmente: ");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos Dollares voce deseja comprar em R$: ");
            double quantidade = double.Parse(Console.ReadLine());
            
            double total = quantidade / dolar;

            double iof = 6.0;
            
            double valorTotal = total * (1 - (iof / 100));
            

            Console.WriteLine($"{total:F2} {quantidade} {valorTotal:F2}");

        }
    }
}