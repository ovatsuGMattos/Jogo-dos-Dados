namespace JogodosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                int posicaoComputador = 0;  
                
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("----------------");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Rodada do Usuário");
                    Console.WriteLine("----------------");
                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    Random geradorDeNumeros = new Random();

                    int resultadoUsuario = SortearDado();

                    Console.WriteLine("----------------");
                    Console.WriteLine($"O valor sorteado foi: {resultadoUsuario}!");
                    Console.WriteLine("----------------");

                    posicaoUsuario += resultadoUsuario;

                    Console.WriteLine($"Você está na posição: {posicaoUsuario} de {limiteLinhaChegada}");

                    if(posicaoUsuario == 5 || posicaoUsuario== 10 || posicaoUsuario == 15 || posicaoUsuario == 25)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço de 3 casas!");
                        Console.WriteLine("----------------");

                        posicaoUsuario += 3;

                        Console.WriteLine($"Você avançou para a posição {posicaoUsuario}!");
                    }
                    else if(posicaoUsuario == 7 || posicaoUsuario == 13 || posicaoUsuario == 20)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
                        Console.WriteLine("----------------");

                        posicaoUsuario -= 2;

                        Console.WriteLine("----------------");
                        Console.WriteLine($"Você recuou para a posição {posicaoUsuario}!");
                        Console.WriteLine("----------------");
                    }

                    if (posicaoUsuario >= limiteLinhaChegada)
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Parabens! Você alcançou a linha de chegada.");
                        Console.WriteLine("--------------------------------------------");

                        jogoEmAndamento = false;
                        continue;
                    }
                        Console.WriteLine("----------------");
                        Console.WriteLine("Rodada do Computador");
                        Console.WriteLine("----------------");
                        Console.Write("Pressione ENTER para vizualizar a rodada do computador...");
                        Console.ReadLine();

                        int resultadoComputador = SortearDado();

                        Console.WriteLine("----------------");
                        Console.WriteLine($"O valor sorteado foi: {resultadoComputador}!");
                        Console.WriteLine("----------------");

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine($"O Computador está na posição: {posicaoComputador} de {limiteLinhaChegada}");

                    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço de 3 casas!");
                        Console.WriteLine("----------------");

                        posicaoComputador += 3;

                        Console.WriteLine($"O computador avançou para a posição {posicaoComputador}!");
                    }
                    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
                        Console.WriteLine("----------------");

                        posicaoComputador -= 2;

                        Console.WriteLine("----------------");
                        Console.WriteLine($"O computador recuou para a posição {posicaoComputador}!");
                        Console.WriteLine("----------------");
                    }

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Que pena! O computador alcançou linha de chegada, tente novamente.");
                        Console.WriteLine("--------------------------------------------");

                        jogoEmAndamento = false;
                        continue;
                    }
                    else
                       
                        Console.ReadLine();
                }
                Console.WriteLine("Deseja continuar? (S/N");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
        static int SortearDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }
    }
}
