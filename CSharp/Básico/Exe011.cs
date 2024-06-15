using System;

namespace CSharp.Básico
{
    class Exe011
    {
        public static void Execute()
        {
            // Aluguel de carros
            Console.WriteLine("Insira quantos dias você passou coim o carro alugado: ");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a distância percorrida com o carro: ");
            float distancia = float.Parse(Console.ReadLine());

            double total = (distancia * 0.2) + (dias * 70);
            Console.WriteLine($"O valor pelo tempo ficou {dias * 70} reais, e o valor da distância ficou {distancia * 0.2}, totalizando {total} reais.");
        }
    }
}
