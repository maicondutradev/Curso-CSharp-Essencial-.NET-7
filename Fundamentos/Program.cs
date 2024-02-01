using System;

namespace Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dados

            //Tipos númericos integrais

            //Tipos números de ponto flutuante

            //Tipos não númericos: boll e char

            //Tipos de Referência

            //Tratamento de data e hora: DateTime
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            DateTime dataEspecifica = new DateTime(2024, 01, 30, 9, 32, 12);
            Console.WriteLine(dataEspecifica);

            //Nullable Types
            int? valor = null; //Nullable<int> valor = null;
            Console.WriteLine(valor);

            //Conversão de tipos

        }
    }
}