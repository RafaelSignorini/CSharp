using System;

namespace CSharp.Básico
{
    class Exe019
    {
        public static void Execute()
        {
            // Maior e menor número
            Console.WriteLine("Insira o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;
            int menor = num1;

            if (num2 > maior)
            {
                maior = num2;
            }
            if (num3 > maior)
            {
                maior = num3;
            }
            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
            }
            Console.WriteLine($"O maior número é {maior} e o menor número é {menor}.");
        }
    }
}
