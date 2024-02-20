using System;

namespace Calculadora
{
    // Definição da classe CalculadoraCientifica
    class CalculadoraCientifica
    {
        // Método para realizar a operação de soma
        public double Somar(double num1, double num2) => num1 + num2;

        // Método para realizar a operação de subtração
        public double Subtrair(double num1, double num2) => num1 - num2;

        // Método para realizar a operação de multiplicação
        public double Multiplicar(double num1, double num2) => num1 * num2;

        // Método para realizar a operação de divisão
        public double Dividir(double num1, double num2) => num1 / num2;

        // Método para realizar a operação de raiz quadrada
        public double RaizQuadrada(double num) => Math.Sqrt(num);

        // Método para realizar a operação de potenciação
        public double Potenciacao(double num, double expoente) => Math.Pow(num, expoente);
    }
}