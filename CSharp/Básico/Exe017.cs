using System;

namespace CSharp.Básico
{
    class Exe017
    {
        public static void Execute()
        {
            // Viagens longas
            do
            {
                Console.WriteLine("Insira a distância em km de sua viagem: ");
                int distancia = int.Parse(Console.ReadLine());

                if (distancia < 0)
                {
                    Console.WriteLine("Distância inválida, tente novamente.");
                    continue;
                }
                if (distancia <= 200)
                {
                    Console.WriteLine($"Viajar por uma distância de {distancia}km faz com que o custo seja de {distancia * 0.5} reais.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Viajar por uma distancia de {distancia}km faz com que o custo seja de {distancia * 0.45} reais.");
                    break;
                }
            } while (true);
        }
    }
}
