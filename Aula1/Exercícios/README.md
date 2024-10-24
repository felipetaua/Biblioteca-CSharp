Claro! Aqui está uma sugestão de como você pode formatar o README do seu repositório no GitHub:

```markdown
# Programa em C#

Este repositório contém um programa simples em C# que realiza três atividades interativas com o usuário.

## Funcionalidades

1. **Exibir Mensagem do Usuário**:
   - O programa solicita que o usuário digite uma mensagem e exibe essa mensagem no console.

2. **Soma de Dois Números**:
   - O usuário é solicitado a inserir dois números inteiros, que são somados e o resultado é exibido.

3. **Cálculo da Média de Três Notas**:
   - O programa pede três notas ao usuário e calcula a média aritmética, apresentando o resultado.

## Código

```csharp
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

        Console.WriteLine("Digite a terceira nota: ");
        String nota3 = Console.ReadLine();
        int n3 = int.Parse(nota3);

        int media = (n1 + n2 + n3) / 3;
        Console.WriteLine("A média do 3º Trimestre é: " + media);
    }
}
```

## Como Executar

1. Certifique-se de ter o [C#](https://dotnet.microsoft.com/download) instalado em sua máquina.
2. Clone este repositório.
3. Abra o terminal e navegue até o diretório do projeto.
4. Compile o programa usando o comando:
   ```
   dotnet build
   ```
5. Execute o programa com o comando:
   ```
   dotnet run
   ```

## Contribuições

Sinta-se à vontade para contribuir com melhorias ou sugestões!

```

Esse formato ajuda a organizar a documentação do seu projeto, tornando-o mais fácil de entender e usar. Se precisar de mais ajustes, é só avisar!
