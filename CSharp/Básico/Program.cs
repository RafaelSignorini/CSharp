using System;

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
                Console.WriteLine("7. Tabuada");
                Console.WriteLine("8. Pintando a parede");
                Console.WriteLine("9. Calculando descontos");
                Console.WriteLine("10. Reajuste salarial");
                Console.WriteLine("11. Parcelamento e porcentagem");
                Console.WriteLine("12. Aluguel de carros");
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
                        case 7:
                            Exe07.Execute();
                            break;
                        case 8:
                            Exe08.Execute();
                            break;
                        case 9:
                            Exe09.Execute();
                            break;
                        case 10:
                            Exe10.Execute();
                            break;
                        case 11:
                            Exe11.Execute();
                            break;
                        case 12:
                            Exe12.Execute();
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