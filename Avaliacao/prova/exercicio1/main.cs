using System;

class Program
{
    public static void Main(string[] args)
    {
        String siga;

        Console.WriteLine("Digite a cor do Semáforo(vermelho, amarelo e verde)");
        siga = Console.ReadLine();

        if (siga == "vermelho")
        {
            Console.WriteLine("Pare");
        }
        else if (siga == "amarelo")
        {
            Console.WriteLine("Atenção");
        }
        else if (siga == "verde")
        {
            Console.WriteLine("Continue");
        }
        else
        {
            Console.WriteLine("Valor incorreto");
        }
    }
}