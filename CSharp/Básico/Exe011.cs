using System;
using System.Runtime.InteropServices;

namespace CSharp.Básico
{
    class Exe011
    {
        public static void Execute()
        {
            Console.WriteLine("Insira o comprimento da parede que deseja pintar: ");
            double comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora insira a altura: ");
            double altura = double.Parse(Console.ReadLine());
            double tinta = (comprimento * altura) / 2;
            Console.WriteLine($"O total de litros de tinta para pintar essa parede serão {tinta}.");
        }
    }
}
