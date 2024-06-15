using System;

namespace CSharp.Básico
{
    class Exe002
    {
        public static void Execute()
        {
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("É um prazer te conhecer ", nome);
            Console.WriteLine($"Olá, tudo bem {nome}?");
        }
    }
}