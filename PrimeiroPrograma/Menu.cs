using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroPrograma
{
    public class Menu : Calculadora
    {

        public Menu()
        {
            Console.WriteLine("Seja Bem vindo a Calculadora Orientada à Objetos !!");
            Console.WriteLine("");
            Console.WriteLine("Digite 1 para Soma");
            Console.WriteLine("Digite 2 para Subtração");
            Console.WriteLine("Digite 3 para Multiplicação");
            Console.WriteLine("Digite 4 para Divisão");
            Console.WriteLine("Digite 5 para Ao Quadrado");
            Console.WriteLine("Digite 6 para Ao Cubo: ");
            Console.WriteLine("Digite 7 para Raiz ao Quadrado: ");
            Console.WriteLine("Digite 8 para Cubica: ");
            Console.WriteLine("Digite 9 para Logaritmo: ");
       
        }

        public void Opcoes(string opcao)
        {
            Usuario usuario = new Usuario(opcao);
            Calculadora calculo = new Calculadora();



            if (opcao == "1")
            {
                Console.WriteLine(calculo.Soma(usuario.NumberOne, usuario.NumberTwo));
            }

            else if (opcao == "2")
            {
                Console.WriteLine(calculo.Subtracao(usuario.NumberOne, usuario.NumberTwo));
            }

            else if (opcao == "3")
            {
                Console.WriteLine(calculo.Multiplicacao(usuario.NumberOne, usuario.NumberTwo));
            }

            else if (opcao == "4")
            {
                if (usuario.NumberTwo == 0)
                {
                    Console.WriteLine("Não EXISTE DIVISÃO POR 0");
                }

                else
                {
                    Console.WriteLine(calculo.Divisao(usuario.NumberOne, usuario.NumberTwo));
                }

            }

            else if (opcao == "5")
            {
                Console.WriteLine(calculo.AoQuadrado(usuario.NumberOne));
            }


            else if (opcao == "6")
            {
                Console.WriteLine(calculo.AoCubo(usuario.NumberOne));
            }


            else if (opcao == "7")
            {
                Console.WriteLine(calculo.RaizQuadrada(usuario.NumberOne));
            }


            else if (opcao == "8")
            {
                Console.WriteLine(calculo.RaizCubica(usuario.NumberOne));
            }


            else if (opcao == "9")
            {
                Console.WriteLine(calculo.Logaritmo(usuario.NumberOne));
            }

        }
    }
}
