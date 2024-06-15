using System;

namespace CSharp.Básico
{
    class Exe020
    {
        public static void Execute()
        {
            // Aumento de salários
            Console.WriteLine("Insira o valor de seu salário: ");
            float salario = float.Parse(Console.ReadLine());

            if (salario < 0)
            {
                Console.WriteLine("Tu é escravo do senai porra?");
            } else if (salario > 0 && salario <= 1420)
            {
                Console.WriteLine($"Com o aumento de salários, você receberá um aumento de {salario * 0.15} reais mensais, totalizando {salario * 1.15} reais.");
            }
            else
            {
                Console.WriteLine($"Com o aumento de salários, você receberá um aumento de {salario * 0.1} reais mensais, totalizando {salario * 1.1} reais.");
            }
        }
    }
}
