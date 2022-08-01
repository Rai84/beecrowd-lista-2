using System;
using System.Globalization;
namespace BEE_1036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, R1, R2;
            string[] nums = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(nums[0]);
            B = Convert.ToDouble(nums[1]);
            C = Convert.ToDouble(nums[2]);
            delta = Math.Pow(B, 2) - 4 * A * C;

            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2 * A);
                Console.WriteLine("R1 = " + R1.ToString("F5"), CultureInfo.InvariantCulture);
                Console.WriteLine("R2 = " + R2.ToString("F5"), CultureInfo.InvariantCulture);
            }
        }
    }
}
