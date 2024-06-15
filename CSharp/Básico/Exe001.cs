using System;

namespace CSharp.Básico
{
    class Exe001
    {
        public static void Execute()
        {
            // Básico
            Console.WriteLine("Hello World!");
            Console.WriteLine(7 + 4);
            Console.WriteLine("7" + "4");
            Console.WriteLine("Olá " + "5");

            // Variáveis
            string nome = "Guanabara";
            int idade = 25;
            double peso = 75.8;
            Console.WriteLine($"{nome}, {idade}, {peso}");
        }
    }
}