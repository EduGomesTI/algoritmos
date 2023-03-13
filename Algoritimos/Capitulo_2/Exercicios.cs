using System;

namespace Capitulo_2
{
  public static class Exercicios
  {
    public static void CelsusToFahrenheit(double celsus)
    {
      var result = (1.8 * celsus) + 32;

      Console.WriteLine($"{celsus}ºC equivale a {result}ºF");
    }
  }
}
