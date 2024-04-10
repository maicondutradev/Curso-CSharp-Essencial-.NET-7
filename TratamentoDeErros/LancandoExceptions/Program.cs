using System.Diagnostics;

try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
class A
{
    public static void ProcessarA()
    {
        B.ProcessarB();
    }
}
class B
{
    public static void ProcessarB()
    {
        C.ProcessarC();
    }
}
class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}


