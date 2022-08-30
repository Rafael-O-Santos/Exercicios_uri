using System;
using System.Globalization;
namespace uri_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double prova1 = A * 3.5;
            double prova2 = B * 7.5;
            double media = (prova1 + prova2) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
