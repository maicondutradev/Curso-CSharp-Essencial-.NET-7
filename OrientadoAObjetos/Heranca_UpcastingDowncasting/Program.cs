namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(10, 20);
            Forma forma = circulo;//Upcasting -> implicita

            //Circulo c = (Circulo)forma;//Downcasting -> explicita

            if (forma is Circulo)//Verifica se o downcast é possivel
            {
                Console.WriteLine("Converteu Forma para Circulo\n");

                //((Circulo)forma).PintarCirculo();
                var tipo = forma as Circulo;
                tipo?.PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação de downcasting não é possível");
            }

            Console.ReadKey();
        }
    }
}