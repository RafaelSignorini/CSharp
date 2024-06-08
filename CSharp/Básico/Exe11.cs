using System;

namespace CSharp.Básico
{
    class Exe11
    {
        public static void Execute()
        {
            // Parcelamento e porcentagem
            Console.WriteLine("Insira o preco do seu produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Este produto à vista está por {preco * 0.9}, porém parcelado em 2x está por {preco * 1.08}.");
        }
    }
}
