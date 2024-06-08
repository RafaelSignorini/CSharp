using System;

namespace CSharp.Básico
{
    class Exe09
    {
        public static void Execute()
        {
            // Calculando descontos
            Console.WriteLine("Insira o valor do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"O preço do produto originalmente é de {preco} reais, porém, com 5 por cento de desconto ele está por {preco * 0.95}");
        }
    }
}
