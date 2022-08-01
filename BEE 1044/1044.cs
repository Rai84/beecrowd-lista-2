using System;

namespace BEE_1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numero = Console.ReadLine().Split(' ');

            int n1 = int.Parse(numero[0]);
            int n2 = int.Parse(numero[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
