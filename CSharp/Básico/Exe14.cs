using System;

namespace CSharp.Básico
{
    class Exe14
    {
        public static void Execute()
        {
            Random random = new Random();
            int aleatorio = random.Next(6);

            do
            {
                Console.WriteLine("Insira um número inteiro entre 0 e 5 para adivinhar o número aleatório gerado pelo computador: ");
                int user = int.Parse(Console.ReadLine());

                if (user < 0 || user > 5)
                {
                    Console.WriteLine("Número inserido inválido, tente novamente.");
                    continue;
                } else if (aleatorio == user)
                {
                    Console.WriteLine("Muito bem, você adivinhou corretamente.");
                    break;
                } else
                {
                    Console.WriteLine("Você errou, tente novamente.");
                    continue;
                }
            } while (true);
        }
    }
}
