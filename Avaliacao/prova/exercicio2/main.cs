using System;

class Program
{
    public static void Main(string[] args)
    {
      // criando variaveis
      float altura = 0;
      float largura = 0;

      // pegando valores
      Console.WriteLine("Calculadora de área de um retangulo");

      Console.WriteLine("Digite a altura:");
      string alturaT = Console.ReadLine();

      Console.WriteLine("Digite a largura:");
      string larguraT = Console.ReadLine();

      // string to float
      float.TryParse(alturaT, out altura);
      float.TryParse(larguraT, out largura);


      // exibindo os resultados
      float resultado = altura * largura;
      Console.WriteLine("A área do retangulo é: " + resultado);
    }
}
