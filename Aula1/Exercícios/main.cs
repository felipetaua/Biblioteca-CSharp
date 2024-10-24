using System;

class Program
{
    public static void Main(string[] args)
    {
        // Atividade 1 - exibir mensagem do usuario no console
        Console.WriteLine("-------Exemplo 1---------");
        Console.WriteLine("Digite alguma coisa:");
        String comentario = Console.ReadLine();

        Console.WriteLine("Você digitou: " + comentario);

        // Atividade 2 - Solicite dois numeros e some
        Console.WriteLine("-------Exemplo 2---------");
        Console.WriteLine("Digite o primeiro valor: ");
        String valor1 = Console.ReadLine();
        int numero1 = int.Parse(valor1);

        Console.WriteLine("Digite o segundo valor: ");
        String valor2 = Console.ReadLine();
        int numero2 = int.Parse(valor2);

        int soma = numero1 + numero2;
        Console.WriteLine("A soma dos dois números é: " + soma);

         // Atividade 3 - media do 3º trimestre
        Console.WriteLine("-------Exemplo 3---------");
        Console.WriteLine("Calculando a media");
        Console.WriteLine("Digite a primeira nota: ");
        String nota1 = Console.ReadLine();
        int n1 = int.Parse(nota1);
      
        Console.WriteLine("Digite a segunda nota: ");
        String nota2 = Console.ReadLine();
        int n2 = int.Parse(nota2);

        Console.WriteLine("Digite a media");
        String nota3 = Console.ReadLine();
        int n3 = int.Parse(nota3);

        int media = (n1 + n2 + n3) / 3;

        Console.WriteLine("A média do 3ºTrimestre é: " + media);
    }
}

