/*
    Figura figura = new Figura();
    figura.Desenhar();

    Circulo circulo = new Circulo();
    circulo.Desenhar();

    Quadrado quadrado = new Quadrado();
    quadrado.Desenhar();

    Triangulo triangulo = new Triangulo();
    triangulo.Desenhar();
*/
var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo(),
    new Quadrado()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}