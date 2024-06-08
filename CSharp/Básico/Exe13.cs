using System;

namespace CSharp.Básico
{
    class Exe13
    {
        public static void Execute()
        {
            // Condições simples, nota
            do
            {
                Console.WriteLine("Insira sua primeira nota: ");
                float nota1 = float.Parse(Console.ReadLine());
                if (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("Valor inserido inválido, tente novamente.");
                    continue;
                }

                Console.WriteLine("Insira sua segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());
                if (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("Valor inserido inválido, tente novamente.");
                    continue;
                }

                float media = (nota1 + nota2) / 2;
                if (media < 7)
                {
                    Console.WriteLine($"Você tirou {media} pontos na média, você foi reprovado.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Você tirou {media} pontos na média, você foi aprovado.");
                    break;
                }
            } while (true); // Laço de repetição a prova de idiota
        }
    }
}
