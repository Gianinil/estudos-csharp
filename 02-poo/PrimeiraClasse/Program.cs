using System;

internal class Program
{
    private static void Main(string[] args)
    {
        carro meuCarro = new carro();
        meuCarro.marca = "Chevrolet";
        meuCarro.modelo = "Onix";
        meuCarro.ano = 2026;

        Console.WriteLine($"Marca: {meuCarro.marca}");
        Console.WriteLine($"Modelo: {meuCarro.modelo}");
        Console.WriteLine($"Ano: {meuCarro.ano}");
    }
}
public class carro
{
    public string marca;
    public string modelo;
    public int ano;
}
