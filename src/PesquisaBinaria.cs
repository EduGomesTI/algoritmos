using System;
using System.Collections;
using System.Reflection;

namespace algoritmos
{
  public static class PesquisaBinaria
  {
    public static string Resultado(int[] lista, int item)
    {
      int baixo = 0;
      int alto = lista.Length - 1;

      while (baixo <= alto)
      {
        int meio = (baixo + alto) / 2;
        int chute = lista[meio];

        if (chute == item)
          return meio.ToString();

        if (chute > item)
          alto = meio - 1;
        else
          baixo = meio + 1;
      }

      return "Item não existe na lista.";
    }
  }
}
