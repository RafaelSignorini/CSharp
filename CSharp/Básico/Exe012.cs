using System;

namespace CSharp.Básico
{
    class Exe012
    {
        public static void Execute()
        {
            Console.WriteLine("Insira o valor do produto que quer comprar: ");
            double valor = double.Parse(Console.ReadLine());
            double preco = valor * 0.95;
            Console.WriteLine($"A loja está com 5 por cento de desconto, o preço do produto ficou por {preco} reais.");
        }
    }
}
