using System;

namespace BEE_1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] numeros = Console.ReadLine().Split(' ');

            A = int.Parse(numeros[0]);
            B = int.Parse(numeros[1]);
            C = int.Parse(numeros[2]);
            D = int.Parse(numeros[3]);

            int soma1 = C + D;
            int soma2 = A + B;

            if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
