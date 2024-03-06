namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(10, 20);
            Forma forma = circulo;//Upcasting -> implicita

            Circulo c = (Circulo)forma;//Downcasting -> explicita

            c.PintarCirculo();
            c.Desenhar();

            Console.WriteLine(c == forma);
            Console.WriteLine(c == circulo);

        }
    }
}