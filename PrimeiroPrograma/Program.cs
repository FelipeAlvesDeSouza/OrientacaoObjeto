using System;
using System.Globalization;
namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string opcao = Console.ReadLine();
            menu.Opcoes(opcao);
        }
   
    }
}



