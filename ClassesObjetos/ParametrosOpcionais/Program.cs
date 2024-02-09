namespace ParametrosOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o endereço: ");
            var destino = Console.ReadLine();

            Console.WriteLine("Informe o titulo: ");
            var titulo = Console.ReadLine();

            Console.WriteLine("Informe o assunto: ");
            var assunto = Console.ReadLine();


            Email email = new Email();
            email.Enviar();
            email.Enviar(destino);
            email.Enviar(destino, titulo);
            email.Enviar(destino, titulo, assunto);

        }
    }

    public class Email
    {
        public void Enviar(string destino = "teste@gmail.com", string titulo = "Orçamento", string assunto = "Aprovação")
        {
            Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
        }
    }
}