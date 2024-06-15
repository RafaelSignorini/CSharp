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
                Console.WriteLine("1. Básico");
                Console.WriteLine("2. Variáveis interativas");
                Console.WriteLine("3. Scripts");
                Console.WriteLine("4. Somas básicas");
                Console.WriteLine("5. Média aritmética");
                Console.WriteLine("6. Tabuada");
                Console.WriteLine("7. Pintando a parede");
                Console.WriteLine("8. Calculando descontos");
                Console.WriteLine("9. Reajuste salarial");
                Console.WriteLine("10. Parcelamento e porcentagem");
                Console.WriteLine("11. Aluguel de carros");
                Console.WriteLine("12. Condições simples, nome");
                Console.WriteLine("13. Condições simples, nota");
                Console.WriteLine("14. Jogo do adivinha");
                Console.WriteLine("15. Leitor da velocidade de carros");
                Console.WriteLine("16. Par ou ímpar");
                Console.WriteLine("17. Viagens longas");
                Console.WriteLine("18. Ano bissexto");
                Console.WriteLine("19. Maior e menor número");
                Console.WriteLine("20. Aumento de salários");
                Console.WriteLine("21. Retas de um triângulo");
                Console.WriteLine("22. Conversor de medidas");
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