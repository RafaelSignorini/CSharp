using System;

namespace CSharp.Básico
{
    class Exe015
    {
        public static void Execute()
        {
            // Leitor da velocidade de carros
            do
            {
                Console.WriteLine("Insira a velocidade do seu carro: ");
                float velocidade = float.Parse(Console.ReadLine());
                float multa = (velocidade - 200) * 80;

                if (velocidade < 0)
                {
                    Console.WriteLine("Velocidade inserida inválida, tente novamente.");
                    continue;
                }
                if (velocidade > 200)
                {
                    Console.WriteLine($"Você estava acima da velocidade permitida, pague {multa} reais de multa.");
                    break;
                }
                else
                {
                    Console.WriteLine("Você estava dentro da velocidade permitida, tenha um bom dia.");
                    break;
                }
            } while (true);
        }
    }
}
