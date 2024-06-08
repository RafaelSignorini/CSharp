using System;

namespace CSharp.Básico
{
    class Exe06
    {
        public static void Execute()
        {
            // Média aritmética
            Console.WriteLine("Insira um valor inteiro entre 0 e 10: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira mais um valor inteiro entre 0 e 10: ");
            int num2 = int.Parse(Console.ReadLine());

            float media = (num1 + num2) / 2;
            Console.WriteLine($"A média aritmética dos dois valores é {media}");
        }
    }
}
