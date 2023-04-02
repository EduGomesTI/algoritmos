namespace algoritmos
{
  public class Recursao
  {
    public int Regressiva(int valor)
    {
      if (valor == 0)
        return 0;

      System.Console.WriteLine(valor);
      return Regressiva(valor - 1);
    }

    public int MenorNumero(int[] valores)
    {
      if (valores.Length == 1)
        return valores[0];

      var primeiro = valores[0];
      var segundo = valores[1];

      if (primeiro <= segundo)
        valores = valores.Where(val => val != valores[1]).ToArray();
      else
        valores = valores.Where(val => val != valores[0]).ToArray();

      return MenorNumero(valores);
    }
  }
}
