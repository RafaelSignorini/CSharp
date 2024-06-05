using System;

namespace ConsoleApp
{
    class Exe03
    {
        public static void Execute()
        {
            // Variáveis interativas
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu peso? ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome}, {idade}, {peso}");
        }
    }
}