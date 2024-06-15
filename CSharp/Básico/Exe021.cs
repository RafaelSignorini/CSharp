using System;

namespace CSharp.Básico
{
    class Exe021
    {
        public static void Execute()
        {
            // Retas de um triângulo
            Console.WriteLine("Insira o comprimento da primeira reta do triângulo: ");
            float r1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o comprimento da segunda reta do triângulo: ");
            float r2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o comprimento da terceira reta do triângulo: ");
            float r3 = float.Parse(Console.ReadLine());

            if (r1 < r2 + r3 && r2<r1 +r3 && r3<r1 + r2)
            {
                Console.WriteLine("Os segmentos acima podem formar um triângulo.");
            }
            else
            {
                Console.WriteLine("Os segmentos acima não podem formar um triângulo.");
            }
        }
    }
}
