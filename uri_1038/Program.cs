using System;

namespace uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, p4, p5;

            p1 = 4.00;
            p2 = 4.50;
            p3 = 5.00;
            p4 = 2.00;
            p5 = 1.50;

            double qunt = double.Parse(Console.ReadLine());

            double PrecoTotal = double.Parse(Console.ReadLine()) + qunt;

            Console.WriteLine("Total: R$");
          
        }
    }
}
