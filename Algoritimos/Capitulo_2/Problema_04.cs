namespace Capitulo_2
{
  public static class Problema_04
  {
    public static void IntercambiarValores(int valor1, int valor2)
    {
      int temp = 0;
      temp = valor1;
      valor1 = valor2;
      valor2 = temp;


      Console.WriteLine($"Valor 1: {valor1}, Valor2: {valor2}.");
    }
  }
}
