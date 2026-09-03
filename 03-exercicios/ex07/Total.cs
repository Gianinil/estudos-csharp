namespace ex06;

public class Total
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void Adicao(int quantidade)
    {
        Quantidade = Quantidade + quantidade;
    }
    
    public void Subtracao(int quantidade)
    {
        Quantidade = Quantidade - quantidade;
    }

    public double QuantidadeTotal()
    {
        return Preco * Quantidade;
    }

    public override string ToString()
    {
        return Nome 
               + ", $" 
               + Preco.ToString("F2") 
               + " " 
               + Quantidade 
               + " Unidades"
               + ", Total: $" 
               + QuantidadeTotal();
    }
}