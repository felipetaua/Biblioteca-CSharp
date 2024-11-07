using System;
class carro
{
    // Propriedades do carro
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"Carro: {Marca} {Modelo}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
      carro meuCarro = new carro();
      meuCarro.Marca = "Porsche";
      meuCarro.Modelo = "911 Carreira GTS";

      // Chamando meu método
      meuCarro.ExibirInfo();
    }
}