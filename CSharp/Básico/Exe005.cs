using System;

namespace CSharp.Básico
{
    class Exe005
    {
        public static void Execute()
        {
            Console.WriteLine("Insira um valor: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"O sucessor de {num} é {num + 1} e o antecessor é {num - 1}");
        }
    }
}
