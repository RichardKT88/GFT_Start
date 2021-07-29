using System;

namespace GFT_Start_4
{
/*    Crie um projeto contendo as classes:

    Quadrado, Retângulo e Círculo.
    Crie também uma interface chamada AreaCalculavel que será implementada
    pelas classes.

    Essa interface conterá um método que calcula a área:

    Área do Quadrado = lado* lado;
        Área do Retângulo = largura* altura;
        Área do Círculo = π* r^2

    Crie uma classe principal Teste instanciando os objetos, passando valores via
    construtor, e exiba no console o cálculo da área.*/
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(4);
            Console.WriteLine("A área do quadrado: " + quadrado.calcularArea());
            Retangulo retangulo = new Retangulo(5, 6);
            Console.WriteLine("A área do retângulo: " + retangulo.calcularArea());
            Circulo circulo = new Circulo(5);
            Console.WriteLine("A área do círculo: " + circulo.calcularArea());
        }
    }
}
