using System;

namespace algoritmos
{
  public static class GerarDados
  {
    public static int[] GerarInteiros(int inicial, int final, int quantidade)
    {
      int[] valores = new int[quantidade];
      Random rnd = new Random();

      for (int i = 0; i < valores.Length; i++)
      {
        var val = 0;
        while (val == 0 || valores.Contains(val))
        {
          val = rnd.Next(inicial, final);
        }
        valores[i] = val;
      }

      return valores;
    }
  }
}
