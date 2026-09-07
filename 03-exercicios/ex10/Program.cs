using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            
            Console.Write("Digite a Altura do retangulo: ");
            ret.Altura  = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a Largura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Deseja saber a area ou o perimetro?: ");
            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "Area":
                    Console.WriteLine(ret.Area().ToString("F2") + " ");
                    break;
                case "Perimetro":
                    Console.WriteLine(ret.Perimetro().ToString("F2") + " ");
                    break;
                default:
                    Console.WriteLine(ret);
                    break;
            }
           
        }
    }
}