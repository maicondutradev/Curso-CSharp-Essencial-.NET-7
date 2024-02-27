public struct Struct1
{

}

public class Classe1
{

}
public class Classe2
{

}
//Uma classe não pode herdar mais de 1 classe
public class ClasseDerivada : Classe1, Classe2
{

}
//Uma classe não pode herdar uma struct
public class ClasseDerivada2 : Struct1
{

}