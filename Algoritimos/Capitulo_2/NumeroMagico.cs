using System;

namespace Capitulo_2
{
  public static class NumeroMagico
  {
    public static void CalcularNumero()
    {
      Console.WriteLine("Digite um número");
      var numero = int.Parse(Console.ReadLine());

      var inverterNumero = Inverter(numero);

      var numeroMagico = 0;

      if (numero > inverterNumero)
        numeroMagico = numero - numeroMagico;
      else
        numeroMagico = numeroMagico - numero;

      var resultado = numeroMagico + Inverter(numeroMagico);

      Console.WriteLine($"O resultado é igual a  {resultado}");
    }

    private static int Inverter(int numero)
    {
      var reverse = string.Join("", Math.Abs(numero).ToString().Reverse());
      return int.Parse(reverse) * Math.Sign(numero);
    }
  }
}
