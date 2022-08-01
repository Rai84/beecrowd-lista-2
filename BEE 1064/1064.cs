using System;
using System.Globalization;
namespace BEE_1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1, p2, p3, p4, p5, p6, p;
            double m1, m2, m3, m4, m5, m6, m;
            double a, b, c, d, e, f;
            a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a >= 0)
            {
                p1 = 1;
                m1 = a;
            }
            else
            {
                p1 = 0;
                m1 = 0;
            }
            if (b >= 0)
            {
                p2 = 1;
                m2 = b;
            }
            else
            {
                p2 = 0;
                m2 = 0;
            }
            if (c >= 0)
            {
                p3 = 1;
                m3 = c;
            }
            else
            {
                p3 = 0;
                m3 = 0;
            }
            if (d >= 0)
            {
                p4 = 1;
                m4 = d;
            }
            else
            {
                p4 = 0;
                m4 = 0;
            }
            if (e >= 0)
            {
                p5 = 1;
                m5 = e;
            }
            else
            {
                p5 = 0;
                m5 = 0;
            }
            if (f >= 0)
            {
                p6 = 1;
                m6 = f;
            }
            else
            {
                p6 = 0;
                m6 = 0;
            }

            p = p1 + p2 + p3 + p4 + p5 + p6;
            m = (m1 + m2 + m3 + m4 + m5 + m6) / p;
            Console.WriteLine($"{p} valores positivos");
            Console.WriteLine(m.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
