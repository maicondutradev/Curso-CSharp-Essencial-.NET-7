namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta();
            ContaInvestimento();
            ContaPoupança();

            Console.ReadKey();
        }

        public static void Conta()
        {
            Conta conta = new Conta();
            conta.Titular = "Maria";
            conta.Numero = 111;

            Console.WriteLine($"\nConta Corrente : Titular: {conta.Titular} - Número: {conta.Numero}");

            Console.WriteLine("Depositando R$ 1.000,00");
            conta.Depositar(1000);

            Console.WriteLine($"Saldo da Conta Corrente : {conta.Saldo.ToString("c")}");

            Console.WriteLine("Sacando R$ 100,00");
            conta.Sacar(100);

            Console.WriteLine($"Saldo da Conta Corrente : {conta.Saldo.ToString("c")}");

            Console.WriteLine("Sacando R$ 2.000,00");
            conta.Sacar(2000);
            Console.WriteLine($"Saldo da Conta Corrente : {conta.Saldo.ToString("c")}");
        }

        public static void ContaInvestimento()
        {
            ContaInvestimento contaInvestimento = new ContaInvestimento();
            contaInvestimento.Titular = "José";
            contaInvestimento.Numero = 222;

            Console.WriteLine($"\nConta Investimento : Titular: {contaInvestimento.Titular} - Número: {contaInvestimento.Numero}");

            Console.WriteLine("Depositando R$ 1.000,00");
            contaInvestimento.Depositar(1000);

            Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");

            Console.WriteLine("Sacando R$ 100,00");
            contaInvestimento.Sacar(100);

            Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");

            Console.WriteLine("Sacando R$ 2.000,00");
            contaInvestimento.Sacar(2000);
            Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");
        }

        public static void ContaPoupança()
        {
            ContaPoupança contaPoupança = new ContaPoupança();
            contaPoupança.Titular = "Mirela";
            contaPoupança.Numero = 333;

            Console.WriteLine($"\nConta Poupança : Titular: {contaPoupança.Titular} - Número: {contaPoupança.Numero}");

            Console.WriteLine("Depositando R$ 1.000,00");
            contaPoupança.Depositar(1000);

            Console.WriteLine($"Saldo da Conta Poupança : {contaPoupança.Saldo.ToString("c")}");

            Console.WriteLine("Sacando R$ 100,00");
            contaPoupança.Sacar(100);

            Console.WriteLine($"Saldo da Conta Poupança : {contaPoupança.Saldo.ToString("c")}");

            Console.WriteLine("Sacando R$ 2.000,00");
            contaPoupança.Sacar(2000);
            Console.WriteLine($"Saldo da Conta Poupança : {contaPoupança.Saldo.ToString("c")}");
        }
    }
}