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

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Parabens! Você alcançou a linha de chegada.");
                        Console.WriteLine("--------------------------------------------");

                    }
                    else
                        Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}");
                    
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
