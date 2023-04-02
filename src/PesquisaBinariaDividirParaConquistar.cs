namespace algoritmos
{
  public static class PesquisaBinariaDividirParaConquistar
  {
    public static string Resultado(int[] lista, int item)
    {

      //TODO: Consertar, está errado.
      // var resultado = string.Empty;

      if (lista.Length == 1 && lista[0] != item)
        return "Item não encontrado";

      if (lista.Length == 1)
        return lista[0].ToString();

      int meio = (lista.Length / 2);
      int chute = lista[meio - 1];

      if (chute == item)
        return chute.ToString();

      if (chute > item)
        lista = lista.Take(meio).ToArray();
      else
        lista = lista.TakeLast(meio).ToArray();

      return Resultado(lista, item);
    }
  }
}
