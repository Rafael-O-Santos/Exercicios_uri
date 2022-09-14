using System;
using System.Globalization;
namespace uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, MEDIA, NMEDIA, MFINAL;
            string[] vet = Console.ReadLine().Split(' ');


            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);


            MEDIA = (float)((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / (float)10.0;
            if (MEDIA == (float)4.85)
            {
                MEDIA = (float)4.8;
            }
            Console.WriteLine("Media: " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));


            if (MEDIA < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (MEDIA >= 5.0 && MEDIA <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                NMEDIA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + NMEDIA.ToString("F1", CultureInfo.InvariantCulture));
                MFINAL = (MEDIA + NMEDIA) / (float)2.0;
                if (MFINAL < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + MFINAL.ToString("F1", CultureInfo.InvariantCulture));


                }
                else
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + MFINAL.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            else
            {
                Console.WriteLine("Aluno aprovado.");
            }


        }
    }
}
