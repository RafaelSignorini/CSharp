using System;

namespace CSharp.Básico
{
    class Exe007
    {
        public static void Execute()
        {
            Console.WriteLine("Insira sua primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());
            float media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média das suas notas é {media}");
        }
    }
}
