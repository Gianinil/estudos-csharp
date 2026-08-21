using System;

namespace operadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores Lógicos
            // && (AND) - Retorna true se ambos os operandos forem true
            // || (OR) - Retorna true se pelo menos um dos operandos for true
            // ! (NOT) - Inverte o valor lógico do operando
            
            bool c1 = 3 > 2 && 5 < 10; // true
            bool c2 = 3 > 3 && 5 < 10; // false
            bool c3 = 3 > 2 || 5 < 10; // true
            bool c4 = 3 > 3 || 5 < 10; // true
            bool c5 = !(3 > 3) && !(5 > 5); // true
            bool c6 = !(3 > 2); // false

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);

        }
    }
}