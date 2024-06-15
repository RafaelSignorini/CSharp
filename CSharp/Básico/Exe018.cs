using System;

namespace CSharp.Básico
{
    class Exe018
    {
        public static void Execute()
        {
            // Ano bissexto
            do
            {
                Console.WriteLine("Insira um ano para saber se é bissexto ou normal: ");
                int year = int.Parse(Console.ReadLine());

                if (year < 0)
                {
                    Console.WriteLine("Ano inserido inválido, tente novamente.");
                    continue;
                }
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"O ano {year} é bissexto.");
                    break;
                }
                else
                {
                    Console.WriteLine($"O ano {year} não é bissexto.");
                    break;
                }
            } while (true);
        }
    }
}
