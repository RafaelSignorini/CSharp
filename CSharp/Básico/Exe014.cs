using System;

namespace CSharp.Básico
{
    class Exe014
    {
        public static void Execute()
        {
            Console.WriteLine("Insira a temperatura atual em °C para saber o equivalente em °F: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine($"A temperatura {c}°C equivale a {f}°F.");
        }
    }
}
