using System;

namespace BEE_1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            int x = 0;
            if (n1 % 2 == 0)
            {
                x = x + 1;
            }
            if (n2 % 2 == 0)
            {
                x = x + 1;
            }
            if (n3 % 2 == 0)
            {
                x = x + 1;
            }
            if (n4 % 2 == 0)
            {
                x = x + 1;
            }
            if (n5 % 2 == 0)
            {
                x = x + 1;
            }

            Console.WriteLine(x + " valores pares");
        }
    }
}
