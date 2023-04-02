using System;
using System.Collections;

namespace algoritmos
{
  public static class Quicksort
  {
    public static int[] Resultado(int[] lista)
    {
      if (lista.Length < 2)
        return lista;

      var pivo = lista[0];
      var listaMenores = new List<int>();
      var listaMaiores = new List<int>();

      for (int i = 0; i < lista.Length; i++)
      {
        if (lista[i] < pivo)
          listaMenores.Add(lista[i]);
      }

      for (int i = 0; i < lista.Length; i++)
      {
        if (lista[i] > pivo)
          listaMaiores.Add(lista[i]);
      }

      var menores = Resultado(listaMenores.ToArray());
      var maiores = Resultado(listaMaiores.ToArray());

      return Juntar(menores, pivo, maiores);
    }

    private static int[] Juntar(int[] menor, int pivo, int[] maior)
    {
      var tamanho = menor.Length + maior.Length + 1;
      var lista = new int[tamanho];
      int index = 0;

      if (menor.Length > 0)
      {
        for (int i = 0; i < menor.Length; i++)
        {
          lista[i] = menor[i];
          index = i;
        }
        index++;
      }

      lista[index] = pivo;

      if (maior.Length > 0)
      {
        index++;
        maior.CopyTo(lista, index);
      }

      return lista;
    }
  }
}
