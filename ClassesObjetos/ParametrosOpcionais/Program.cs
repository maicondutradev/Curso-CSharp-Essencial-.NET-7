namespace ParametrosOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Enviar("teste@gmail.com");

        }
    }

    public class Email
    {
        public void Enviar(string destino, string titulo = "Orçamento", string assunto = "Aprovação")
        {
            Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
        }
    }
}