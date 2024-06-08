using System;

namespace CSharp.Básico
{
    class Exe07
    {
        public static void Execute()
        {
            // Pintando a parede
            Console.WriteLine("Insira o comprimento da parede");
            float comprimento = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura da parede");
            float altura = float.Parse(Console.ReadLine());

            float total = (comprimento * altura) / 2;
            Console.WriteLine($"O total de tinta a ser gasto sera de {total} metros quadrados.");
        }
    }
}
