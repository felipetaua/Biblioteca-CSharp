using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativa = 0;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao jogo da advinhação em C#");

        // Enquanto o usuario não acertar
        while (!acertou)
        {
            Console.WriteLine("Digite sua tentativa: ");
            string input = Console.ReadLine();
            // Verifica se o usuario digitou um numero
            if (int.TryParse(input, out tentativa))
            {
                // Logica do jogo
                if (tentativa < 1 || tentativa > 100)
                {
                    Console.WriteLine("Por favor digite um número entre 1 e 100");
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O numero secreto é maior");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("O numero secreto é menor!");
                }
                else
                {
                    Console.WriteLine("Parabens voce acertou");
                    acertou = true;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite outro número");
            }
        }
      Console.WriteLine("Obrigado por jogar meu jogo em C#");
    }
}