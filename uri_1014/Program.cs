using System;
using System.Globalization;
namespace uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            //--VAR--//
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double CSMD = X / Y;

            //--cw--//
            Console.WriteLine(CSMD.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
