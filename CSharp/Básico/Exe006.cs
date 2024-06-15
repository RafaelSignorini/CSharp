using System;

namespace CSharp.Básico
{
    class Exe006
    {
        public static void Execute()
        {
            Console.WriteLine("Insira um valor: ");
            int num = int.Parse(Console.ReadLine());
            double sqrtValue = Math.Sqrt(num);
            Console.WriteLine($"O dobro de {num} é igual {num * 2}, o triplo é {num * 3} e a raiz é {sqrtValue:F2}");
        }
    }
}
