using System;
using System.Globalization;
namespace BEE_1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int x = 0;
            if (n1 > 0.0)
            {
                x = x + 1;
            }
            if (n2 > 0.0)
            {
                x = x + 1;
            }
            if (n3 > 0.0)
            {
                x = x + 1;
            }
            if (n4 > 0.0)
            {
                x = x + 1;
            }
            if (n5 > 0.0)
            {
                x = x + 1;
            }
            if (n6 > 0.0)
            {
                x = x + 1;
            }
            Console.WriteLine(x + " valores positivos");
        }
    }
}
