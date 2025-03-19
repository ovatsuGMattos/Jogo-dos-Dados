namespace JogodosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoJogador = 0;
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("----------------");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("----------------");

                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    Random geradorDeNumeros = new Random();

                    int resultado = geradorDeNumeros.Next(1, 7);

                    Console.WriteLine("----------------");
                    Console.WriteLine($"O valor sorteado foi: {resultado}!");
                    Console.WriteLine("----------------");

                    posicaoJogador += resultado;

                    Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}");

                    if(posicaoJogador == 5 || posicaoJogador== 10 || posicaoJogador == 15 || posicaoJogador == 25)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço de 3 casas!");
                        Console.WriteLine("----------------");

                        posicaoJogador += 3;

                        Console.WriteLine($"Você avançou para a posição {posicaoJogador}!");
                    }
                    else if(posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
                        Console.WriteLine("----------------");

                        posicaoJogador -= 2;

                        Console.WriteLine("----------------");
                        Console.WriteLine($"Você recuou para a posição {posicaoJogador}!");
                        Console.WriteLine("----------------");
                    }

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Parabens! Você alcançou a linha de chegada.");
                        Console.WriteLine("--------------------------------------------");

                    }
                    else

                        Console.WriteLine("--------------------------------------------");
                    Console.ReadLine();
                }
                Console.WriteLine("Deseja continuar? (S/N");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
