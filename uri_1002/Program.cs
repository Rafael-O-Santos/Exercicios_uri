using System;
using System.Globalization;
namespace uri_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double π = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double area = π * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
