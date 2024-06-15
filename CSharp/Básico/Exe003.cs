using System;
using System.Runtime.Serialization;

namespace CSharp.Básico
{
    class Exe003
    {
        public static void Execute()
        {
            Console.WriteLine("Insira um valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro valor: ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine($"A soma entre {num1} e {num2} vale {soma}");
        }
    }
}