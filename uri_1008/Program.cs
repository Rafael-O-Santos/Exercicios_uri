using System;
using System.Globalization;
namespace uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            //--número do funcionário--//
            int Nf = int.Parse(Console.ReadLine());
            //--horas trabalhadas--//
            int Ht = int.Parse(Console.ReadLine());
            //--Recebe a Hora--//
            double RAH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //--Calculo--//
            double SALARIO = Ht * RAH;

            //--Console--//

            Console.WriteLine("NUMBER = " + Nf);
            Console.WriteLine("SALARY = U$ " + SALARIO.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
