using System;

namespace CSharp.Básico
{
    class Exe22
    {
        public static void Execute()
        {
            // Conversor de medidas
            Console.WriteLine("Insira uma medida em metros para converte-lá: ");
            float metros = float.Parse(Console.ReadLine());

            float km = metros / 1000;
            float hm = metros / 100;
            float dam = metros / 10;
            float dm = metros * 10;
            float cm = metros * 100;
            float mm = metros * 1000;

            Console.WriteLine($"{metros} metros equivalem à: ");
            Console.WriteLine($"{km} km;");
            Console.WriteLine($"{hm} hm;");
            Console.WriteLine($"{dam} dam;");
            Console.WriteLine($"{dm} dm;");
            Console.WriteLine($"{cm} cm;");
            Console.WriteLine($"{mm} mm;");
        }
    }
}
