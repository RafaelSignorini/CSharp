using System;

namespace CSharp.Básico
{
    class Exe03
    {
        public static void Execute()
        {
            // formatted strings / fstrings
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}, tudo bem com você?");
        }
    }
}