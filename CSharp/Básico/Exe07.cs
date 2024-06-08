using System;

namespace CSharp.Básico
{
    class Exe07
    {
        public static void Execute()
        {
            // Tabuada
            Console.WriteLine("Insira um número inteiro para saber sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"A tabuada de {num} é a seguinte: ");
            Console.WriteLine($"{num} x 1 = {num}");
            Console.WriteLine($"{num} x 2 = {num * 2}");
            Console.WriteLine($"{num} x 3 = {num * 3}");
            Console.WriteLine($"{num} x 4 = {num * 4}");
            Console.WriteLine($"{num} x 5 = {num * 5}");
            Console.WriteLine($"{num} x 6 = {num * 6}");
            Console.WriteLine($"{num} x 7 = {num * 7}");
            Console.WriteLine($"{num} x 8 = {num * 8}");
            Console.WriteLine($"{num} x 9 = {num * 9}");
            Console.WriteLine($"{num} x 10 = {num * 10}");
        }
    }
}
