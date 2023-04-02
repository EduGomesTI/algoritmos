using System;

namespace algoritmos
{
  public static class OrdenarPorSelecao
  {
    public static int[] OrdenacaoPorSelecao(int[] lista)
    {
      int tamanho = lista.Length;
      int[] novo = new int[tamanho];

      for (int i = 0; i < tamanho; i++)
      {
        var menor = BuscaMenor(lista);
        novo[i] = lista[menor];
        lista = lista.Where(val => val != lista[menor]).ToArray();
      }

      return novo;
    }


    private static int BuscaMenor(int[] lista)
    {
      var menor = lista[0];
      var menor_indice = 0;

      for (int i = 0; i < lista.Length; i++)
      {
        if (lista[i] < menor)
        {
          menor = lista[i];
          menor_indice = i;
        }
      }

      return menor_indice;
    }
  }
}
