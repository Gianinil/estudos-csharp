namespace ex10;

public class Retangulo
{
    public double Altura { get; set;}
    public double Largura { get; set;}

    public Retangulo()
    {
        
    }

    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }
    
    public double Area()
    {
        return Altura * Largura;
    }

    public double Perimetro()
    {
        return 2 * (Largura + Altura);
    }

    public override string ToString()
    {
        return "Area do retangulo: " 
               + Area() 
               + " Perimetro: " 
               + Perimetro();
    }
}