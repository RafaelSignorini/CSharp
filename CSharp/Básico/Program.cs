﻿using System;

namespace CSharp.Básico
{
    class Program
    {
        static void Main()
        {
            int escolha;

            do
            {
                Console.WriteLine("Escolha um exercício para executar: ");
                Console.WriteLine("1. Básico");
                Console.WriteLine("2. Variáveis");
                Console.WriteLine("3. Variáveis interativas");
                Console.WriteLine("4. Scripts");
                Console.WriteLine("5. Somas básicas");
                Console.WriteLine("6. Média aritmética");
                Console.Write("Insira o número do exercício: ");

                // Verifica se a entrada do usuário é um número inteiro válido
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            Exe01.Execute();
                            break;
                        case 2:
                            Exe02.Execute();
                            break;
                        case 3:
                            Exe03.Execute();
                            break;
                        case 4:
                            Exe04.Execute();
                            break;
                        case 5:
                            Exe05.Execute();
                            break;
                        case 6:
                            Exe06.Execute();
                            break;
                        case 0:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Escolha inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida, por favor insira um número inteiro.");
                    escolha = -1; // Para continuar o loop em caso de entrada inválida
                }
            } while (escolha != 0);
        }
    }
}