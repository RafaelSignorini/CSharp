using System;

namespace CSharp.Básico
{
    class Exe015
    {
        public static void Execute()
        {
            Console.WriteLine("Insira quantos dias você passou coim o carro alugado: ");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a distância percorrida com o carro: ");
            float distancia = float.Parse(Console.ReadLine());

            double total = (distancia * 0.15) + (dias * 60);
            Console.WriteLine($"O valor total do alguel foi de {total} reais.");
        }
    }
}
