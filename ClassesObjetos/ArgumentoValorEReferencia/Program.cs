//Argumento passado por valor
/*
    int x = 20;

    Console.WriteLine($"Valor do argumento x antes de passar por valor {x}");

    Calculo calculo = new Calculo();

    calculo.Dobrar(x);

    Console.WriteLine($"Valor do argumento x depois de passar por valor: {x}");


    public class Calculo
    {
        public void Dobrar(int y)
        {
            y *= 2;
            Console.WriteLine($"Valor do parâmetro y no método dobrar: {y}");
        }
    }
*/

/*
    //Argumento passado por referência (ref)
    int x = 20;

    Console.WriteLine($"Valor do argumento x antes de passar por valor {x}");

    Calculo calculo = new Calculo();

    calculo.Dobrar(ref x);

    Console.WriteLine($"Valor do argumento x depois de passar por valor: {x}");


    public class Calculo
    {
        public void Dobrar(ref int y)
        {
            y *= 2;
            Console.WriteLine($"Valor do parâmetro y no método dobrar: {y}");
        }
}
*/

//Argumento passado por referência (out)
// Solicita ao usuário que informe o raio do círculo
Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

// Cria uma instância da classe Circulo
Circulo circulo = new Circulo();

// Chama o método CalcuraAreaPerimetro da instância circulo para calcular a circunferência e a área,
// passando o raio como argumento por referência (out) e armazenando os resultados nas variáveis circuferencia e area
double circunferencia = circulo.CalcuraAreaPerimetro(raio, out double area);

// Exibe na tela o resultado do cálculo da circunferência
Console.WriteLine($"Perímetro da Circunferência: {circunferencia}");

// Exibe na tela o resultado do cálculo da área
Console.WriteLine($"Área da Circunferência: {area}");

// Definição da classe Circulo
public class Circulo
{
    // Método para calcular a área e o perímetro de um círculo com base no raio
    public double CalcuraAreaPerimetro(double raio, out double area)
    {
        // Calcula a área do círculo e armazena o resultado na variável 'area'
        area = Math.PI * Math.Pow(raio, 2);

        // Calcula o perímetro da circunferência e o retorna
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
