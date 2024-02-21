// Instanciando um objeto da classe Time
Time time = new Time();

// Atribuindo valores ao array interno da instância de Time usando o indexador 'set'
time[1] = "Flamengo";
time[3] = "Vasco";
time[5] = "Fluminense";
time[7] = "Botafogo";
time[-1] = "Palmeiras";  // Index -1 não é válido, então esse valor não será atribuído
time[1000] = "Bahia";    // Index 1000 não é válido, então esse valor não será atribuído

// Obtendo valores do array interno da instância de Time usando o indexador 'get'
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];  // Index -1 não é válido, então o valor retornado será "ERRO"
string valor6 = time[1000];  // Index 1000 não é válido, então o valor retornado será "ERRO"

// Exibindo os valores obtidos
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

// Aguardando a entrada do usuário antes de encerrar a aplicação
Console.ReadKey();

