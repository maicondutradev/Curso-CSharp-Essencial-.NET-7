using System.Reflection;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IControle demo = new Demo();
        demo.Exibir();
        demo.Desenhar();
        demo.Nome = "Maicon";

        IGrafico demo_ = new Demo();
        demo_.Pintar();


        Console.ReadKey();
    }
    interface IControle
    {
        string Nome { get; set; }
        void Desenhar();
        public void Exibir()
        {
            Console.WriteLine("teste...");
        }
    }
    interface IGrafico
    {
        void Pintar();
    }
    public class Demo : IControle, IGrafico
    {
        public string Nome { get; set; } = string.Empty;

        public void Desenhar()
        {
            Console.WriteLine("Desenhando...");
        }

        public void Pintar()
        {
            Console.WriteLine("Pintando...");
        }
    }
}
