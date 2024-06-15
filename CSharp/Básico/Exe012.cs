using System;

namespace CSharp.Básico
{
    class Exe012
    {
        public static void Execute()
        {
            // Condições simples, nome
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}. Tudo bem?");
            if (nome == "Stefany") // Condição
            {
                Console.WriteLine("Seu nome é lindo.");
            }
        }
    }
}
