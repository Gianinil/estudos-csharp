using System;
using ex09;

class Program
{
    static void Main(string[] args)
    {
        Conta conta;

        Console.Write("Entre o numero da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Havera deposito inicial (s/n) ");
        char resp = char.Parse(Console.ReadLine());

        if (resp == 's')
        {
            Console.WriteLine("Digite o valor do deposito inicial");
            double depositoInicial = double.Parse(Console.ReadLine());
            conta = new Conta(numero, titular, depositoInicial);
        }
        else
        {
            conta = new Conta(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para deposito: ");
        double valor = double.Parse(Console.ReadLine());
        conta.Deposito(valor);
        Console.WriteLine();
        Console.Write("Dados da conta: ");
        Console.Write(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para saque: ");
        valor = double.Parse(Console.ReadLine());
        conta.Saque(valor);
        Console.WriteLine();
        Console.Write("Dados da conta: ");
        Console.Write(conta);
    }
}