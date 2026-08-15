// Fundamentos de C#: tipos, controle de fluxo e métodos.

Console.WriteLine("=== Tipos e inferência ===");

// var deixa o compilador inferir o tipo, mas ele continua estático:
// uma vez int, sempre int.
var idade = 19;
var nome = "Lucas";
var altura = 1.78;
var estudando = true;

Console.WriteLine($"{nome}, {idade} anos, {altura:F2}m, estudando: {estudando}");
Console.WriteLine($"idade é do tipo {idade.GetType().Name}");

Console.WriteLine();
Console.WriteLine("=== Controle de fluxo ===");

for (int i = 1; i <= 15; i++)
{
    Console.WriteLine(FizzBuzz(i));
}

Console.WriteLine();
Console.WriteLine("=== Métodos ===");

Console.WriteLine($"Fatorial de 5: {Fatorial(5)}");
Console.WriteLine($"Média de [7, 8, 10]: {Media(7, 8, 10):F2}");

// A expressão switch devolve um valor direto, sem break em cada caso.
static string FizzBuzz(int numero) => (numero % 3, numero % 5) switch
{
    (0, 0) => "FizzBuzz",
    (0, _) => "Fizz",
    (_, 0) => "Buzz",
    _ => numero.ToString()
};

// Versão iterativa: evita estourar a pilha em entradas grandes.
static long Fatorial(int numero)
{
    if (numero < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(numero), "Fatorial exige um número não negativo.");
    }

    long resultado = 1;
    for (int i = 2; i <= numero; i++)
    {
        resultado *= i;
    }

    return resultado;
}

// params aceita quantos argumentos vierem, inclusive nenhum — daí a guarda.
static double Media(params int[] valores)
{
    if (valores.Length == 0)
    {
        throw new ArgumentException("Informe ao menos um valor.", nameof(valores));
    }

    int soma = 0;
    foreach (int valor in valores)
    {
        soma += valor;
    }

    return (double)soma / valores.Length;
}
