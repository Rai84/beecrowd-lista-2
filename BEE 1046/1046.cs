using System;

namespace BEE_1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tempo = Console.ReadLine().Split(' ');
            int inicio = int.Parse(tempo[0]);
            int fim = int.Parse(tempo[1]);

            int duracao;
            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}
