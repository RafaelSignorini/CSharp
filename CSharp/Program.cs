using System;
using CSharp.Básico;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            int escolha;

            do
            {
                Console.WriteLine("Escolha um exercício para executar: ");
                Console.WriteLine("1.");
                Console.WriteLine("2.");
                Console.WriteLine("3.");
                Console.WriteLine("4.");
                Console.WriteLine("5.");
                Console.WriteLine("6.");
                Console.WriteLine("7.");
                Console.WriteLine("8.");
                Console.WriteLine("9.");
                Console.WriteLine("10.");
                Console.WriteLine("11.");
                Console.WriteLine("12.");
                Console.WriteLine("13.");
                Console.WriteLine("14.");
                Console.WriteLine("15.");
                Console.WriteLine("16.");
                Console.WriteLine("17.");
                Console.WriteLine("18.");
                Console.WriteLine("19.");
                Console.WriteLine("20.");
                Console.WriteLine("21.");
                Console.WriteLine("22.");
                Console.Write("Insira o número do exercício: ");

                // Verifica se a entrada do usuário é um número inteiro válido
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            Exe001.Execute();
                            break;
                        case 2:
                            Exe002.Execute();
                            break;
                        case 3:
                            Exe003.Execute();
                            break;
                        case 4:
                            Exe004.Execute();
                            break;
                        case 5:
                            Exe005.Execute();
                            break;
                        case 6:
                            Exe006.Execute();
                            break;
                        case 7:
                            Exe007.Execute();
                            break;
                        case 8:
                            Exe008.Execute();
                            break;
                        case 9:
                            Exe009.Execute();
                            break;
                        case 10:
                            Exe010.Execute();
                            break;
                        case 11:
                            Exe011.Execute();
                            break;
                        case 12:
                            Exe012.Execute();
                            break;
                        case 13:
                            Exe013.Execute();
                            break;
                        case 14:
                            Exe014.Execute();
                            break;
                        case 15:
                            Exe015.Execute();
                            break;
                        case 16:
                            Exe016.Execute();
                            break;
                        case 17:
                            Exe017.Execute();
                            break;
                        case 18:
                            Exe018.Execute();
                            break;
                        case 19:
                            Exe019.Execute();
                            break;
                        case 20:
                            Exe020.Execute();
                            break;
                        case 21:
                            Exe021.Execute();
                            break;
                        case 22:
                            Exe022.Execute();
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