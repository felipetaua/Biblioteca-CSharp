using System;

class Program {
  public static void Main (string[] args) {
    // Solicitando a nota que o aluno tirou
    Console.WriteLine("Insira sua nota(0 a 100)");
    int nota = int.Parse(Console.ReadLine());

    // Verificando se a nota é válida
    if (nota >= 0 && nota <= 100) {
      // Verificando se a nota é azul
      if (nota >= 50) {
        Console.WriteLine("Parabéns! Você com nota azul");
      } else {
        Console.WriteLine("Estude mais, evolua, compreenda seus erros, expanda sua mente. Você esta de recuperação!");
      }
    } else {
      Console.WriteLine("Nota inválida!  outra nota");
    }
  }
}