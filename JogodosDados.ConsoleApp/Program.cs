﻿namespace JogodosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("----------------");

                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();

                Random geradorDeNumeros = new Random();
                
                int resultado = geradorDeNumeros.Next(1,7);

                Console.WriteLine("----------------");
                Console.WriteLine($"O valor sorteado foi: {resultado}!");
                Console.WriteLine("----------------");

                Console.WriteLine("Deseja continuar? (S/N");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }   
        }
    }
}
