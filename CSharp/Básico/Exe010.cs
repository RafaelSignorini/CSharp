using System;

namespace CSharp.Básico
{
    class Exe010
    {
        public static void Execute()
        {
            Console.WriteLine("Insira um valor em reais: ");
            double reais = double.Parse(Console.ReadLine());
            double dolar = reais / 3.27;
            Console.WriteLine($"Com {reais} reais, você pode comprar {dolar} dolares.");
        }
    }
}
