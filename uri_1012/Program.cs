using System;

namespace uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            //---A B C---//
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            //---Área do Triângulo retângulo---//

            double BASE = A;
            double Altura = C;
            double Area = BASE * Altura / 2;

            //---Área do círculo de raio C * pi---//

            double Pi = 3.14159;
            double Raio2 = C;
            double Area2 = Pi * Raio2;

            //---Área do trapézio---//

            double bMA = A;
            double bME = B;
            double Area3 = (bMA + bME) / 2;

            //---Área do quadrado---//

            double Base = B;
            double ALTURA = double.Parse(Console.ReadLine());
            double Area4 = Base * ALTURA;

            //---Área do retângulo---//

            double Compri = A;
            double Largura = B;
            double Area5 = Compri * Largura;

            //---Console---//

            Console.WriteLine("TRIANGULO: " + Area);
            Console.WriteLine("CIRCULO: " + Area2);
            Console.WriteLine("TRAPEZIO: " + Area3);
            Console.WriteLine("QUADRADO: " + Area4);
            Console.WriteLine("RETANGULO: " + Area5);



        }
    }
}
