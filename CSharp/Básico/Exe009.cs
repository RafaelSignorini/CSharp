using System;

namespace CSharp.Básico
{
    class Exe009
    {
        public static void Execute()
        {
            // Reajuste salarial
            Console.WriteLine("Insira o valor do seu salário: ");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine($"O seu salário de {salario} reais recebera um aumento de {salario * 0.15}, totalizando {salario * 1.15} reais.");
        }
    }
}
