namespace Abstract;

public abstract class Forma
{
    //Propriedades
    public string? Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    //Métodos abstratos
    public abstract void CalcularArea();
    public abstract void CalcuraPerimetro();

    //Método comum
    public string Descricao()
    {
        return "Sou a classe abstrata Forma";
    }
}