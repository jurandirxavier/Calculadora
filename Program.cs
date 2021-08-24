using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("===================================");
            Console.WriteLine("Digite o número da opção escolhida: ");
            short opcaoEscolhida = short.Parse(Console.ReadLine());

            if (opcaoEscolhida >= 0 && opcaoEscolhida <= 4)
            {
                switch (opcaoEscolhida)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 0:
                        Final();
                        System.Environment.Exit(0); break;
                    default: Menu(); break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, escolha uma opção válida!!!");
                Console.WriteLine("Tecle ENTER para retornar ao Menu Inicial!");
                Console.ReadKey();
                Menu();
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = valor1 + valor2;

            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            //Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
            //Console.WriteLine("O resultado da soma é " + (valor1 + valor2));

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.WriteLine("Tecle um 'número' para VOLTAR ao Menu Inicial ou '0' para SAIR");
                        
            short opcao = short.Parse(Console.ReadLine());
            if (opcao != 0)
            {
                Menu();
            }
            else
            {
                Final();
                System.Environment.Exit(0);
            }
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resulatdo da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Final()
        {
            Console.WriteLine();
            Console.WriteLine("OBRIGADO por utilizar o aplicativo!");
            Console.WriteLine();
        }
    }
}
