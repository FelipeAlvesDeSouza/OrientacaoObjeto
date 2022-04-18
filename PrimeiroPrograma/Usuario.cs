using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroPrograma
{
    public class Usuario
    {
        public double NumberOne { get; private set; }
        public double NumberTwo { get; private set; }

        public Usuario (string opcao)
        {
            if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4")
            {
                Console.WriteLine("Digite o primeiro Número");
                this.NumberOne = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo Número");
                this.NumberTwo = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Digite um Número");
                this.NumberOne = double.Parse(Console.ReadLine());
            }
                

        }

        public double getNumberOne()
        {
            return this.NumberOne;
        }

        public double getNumberTwo()
        {
            return this.NumberOne;
        }
    }
}
