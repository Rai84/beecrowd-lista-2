using System;
using System.Globalization;
namespace BEE_1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nota = Console.ReadLine().Split(' ');

            float N1 = float.Parse(nota[0], CultureInfo.InvariantCulture);
            float N2 = float.Parse(nota[1], CultureInfo.InvariantCulture);
            float N3 = float.Parse(nota[2], CultureInfo.InvariantCulture);
            float N4 = float.Parse(nota[3], CultureInfo.InvariantCulture);

            float NotaFinal = (float)(N1 * 2.0 + N2 * 3.0 + N3 * 4.0 + N4 * 1.0) / (float)10.0;

            if (NotaFinal == 4.85f)
            {
                NotaFinal = 4.8f;
            }

            if (NotaFinal >= 7.0)
            {
                Console.WriteLine("Media: " + NotaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (NotaFinal >= 5.0 && NotaFinal <= 6.9)
            {
                Console.WriteLine("Media: " + NotaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                float NotaFinal2 = (NotaFinal + exame) / 2;

                if (NotaFinal2 >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + NotaFinal2.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Media: " + NotaFinal2.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            else
            {
                Console.WriteLine("Media: " + NotaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
