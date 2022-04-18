using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroPrograma
{
    public class Calculadora
    {

        
        public double Soma(double number1 , double number2)
        {
            return number1 + number2;
        }

        public double Subtracao(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiplicacao(double number1, double number2)
        {
            return number1 * number2;
        }


        public double Divisao(double number1, double number2)
        {
            return number1 / number2;  
        }

        public double AoQuadrado(double number1)
        {
            return number1 * number1;
        }

        public double AoCubo(double number1)
        {
            return number1 * number1 * number1; 
        }

        public double RaizQuadrada(double number1)
        {
            return Math.Sqrt(number1);
        }

        public double RaizCubica(double number1)
        {
            return Math.Cbrt(number1);
        }

        public double Logaritmo(double number1)
        {
            return Math.Log10(number1);
        }

    }
}
