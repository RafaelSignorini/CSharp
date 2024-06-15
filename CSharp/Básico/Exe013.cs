using System;

namespace CSharp.Básico
{
    class Exe013
    {
        public static void Execute()
        {
            Console.WriteLine("Insira o valor de seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double aumento = salario * 0.15;
            Console.WriteLine($"O seu salário de {salario} reais receberá um aumento de {aumento} reais, totalizando {aumento + salario} reais.");
        }
    }
}
