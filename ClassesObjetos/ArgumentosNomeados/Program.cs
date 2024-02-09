namespace ArgumentosNomeados
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Enviar(destino: "teste@gmail.com", assunto: "Reunião Orçamento", titulo: "Urgente");
        }
    }

    class Email
    {
        public void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
        }
    }
}