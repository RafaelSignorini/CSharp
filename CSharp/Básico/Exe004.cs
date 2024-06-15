using System;

namespace CSharp.Básico
{
    class Exe004
    {
        public static void Execute()
        {
            Console.Write("Insira alguma coisa: ");
            string a = Console.ReadLine();
            Console.WriteLine($"O tipo primitivo desse valor é {a.GetType()}");
            Console.WriteLine($"Só tem espaços? {string.IsNullOrWhiteSpace(a)}");
            Console.WriteLine($"É um número? {IsNumeric(a)}");
            Console.WriteLine($"É alfabético? {IsAlpha(a)}");
            Console.WriteLine($"É alfanumérico? {IsAlnum(a)}");
            Console.WriteLine($"Está em maiúscula? {IsUpper(a)}");
            Console.WriteLine($"Está em minúscula? {IsLower(a)}");
            Console.WriteLine($"Está capitalizada? {IsTitle(a)}");
        }
        static bool IsNumeric(string str)
        {
            return int.TryParse(str, out _);
        }
        static bool IsAlpha(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }
        static bool IsAlnum(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }
        static bool IsUpper(string str)
        {
            foreach (char c in str)
            {
                if (char.IsLetter(c) && !char.IsUpper(c))
                    return false;
            }
            return true;
        }
        static bool IsLower(string str)
        {
            foreach (char c in str)
            {
                if (char.IsLetter(c) && !char.IsLower(c))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsTitle(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                if (word.Length == 0)
                    continue;
                if (!char.IsUpper(word[0]))
                    return false;
                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLower(word[i]))
                        return false;
                }
            }
            return true;
        }
    }
}