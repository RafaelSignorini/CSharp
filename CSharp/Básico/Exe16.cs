using System;

namespace CSharp.Básico
{
    class Exe16
    {
        public static void Execute()
        {
            // Par ou ímpar
            Console.WriteLine("Insira um número para saber se é ímpar ou par: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par.");
            }
            else
            {
                Console.WriteLine($"O número {num} é ímpar");
            }
        }
    }
}
