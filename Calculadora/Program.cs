using System;
using System.Collections.Generic; // Adicione esta linha para usar listas

namespace Calculadora
{
    class Program
    {
        static List<double> resultados = new List<double>(); // Lista para armazenar resultados

        static void Main(string[] args)
        {
            // Da boas-vindas à Calculadora Científica
            Console.WriteLine("Bem vindo(a) à calculadora científica!");

            while (true)
            {
                // Exibe as opções de operação ao usuário
                ExibirOpcoes();

                // Lê a opção escolhida pelo usuário
                int opcao = LerOpcao();

                if (opcao == 7) // Opção para mostrar resultados recentes
                {
                    MostrarResultadosRecentes();
                    continue; // Retorna ao início do loop para mostrar o menu novamente
                }

                // Realiza a operação de acordo com a opção escolhida
                double resultado = RealizarOperacao(opcao);

                // Adiciona o resultado à lista de resultados recentes
                resultados.Add(resultado);

                // Mostra o resultado da operação ao usuário
                Console.WriteLine("Resultado: " + resultado);
            }
        }

        static void ExibirOpcoes()
        {
            Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("7 - Mostrar resultados recentes");
            Console.WriteLine("8 - Sair");
        }

        static int LerOpcao()
        {
            Console.WriteLine("Digite o número correspondente à operação:");
            return int.Parse(Console.ReadLine());
        }

        static double RealizarOperacao(int opcao)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica();

            double num1 = 0, num2 = 0;

            switch (opcao)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    num1 = LerNumero("Digite o primeiro número:");
                    num2 = LerNumero("Digite o segundo número:");
                    break;
                case 5:
                    num1 = LerNumero("Digite o número para calcular a raiz quadrada:");
                    break;
                case 6:
                    num1 = LerNumero("Digite a base:");
                    num2 = LerNumero("Digite o expoente:");
                    break;
            }

            switch (opcao)
            {
                case 1: return calc.Somar(num1, num2);
                case 2: return calc.Subtrair(num1, num2);
                case 3: return calc.Multiplicar(num1, num2);
                case 4: return calc.Dividir(num1, num2);
                case 5: return calc.RaizQuadrada(num1);
                case 6: return calc.Potenciacao(num1, num2);
                default: throw new ArgumentException("Opção inválida!");
            }
        }

        static double LerNumero(string mensagem)
        {
            Console.WriteLine(mensagem);
            return double.Parse(Console.ReadLine());
        }

        static void MostrarResultadosRecentes()
        {
            if (resultados.Count == 0)
            {
                Console.WriteLine("Nenhum resultado recente.");
                return;
            }

            Console.WriteLine("\nResultados Recentes:");
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}
