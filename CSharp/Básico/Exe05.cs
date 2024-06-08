using System;

namespace CSharp.Básico
{
    class Exe05
    {
        public static void Execute()
        {
            Console.WriteLine("Insira um número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira mais um número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}
