namespace Capitulo_2
{
  public static class Problema_02
  {
    public static double[] Raiz_Quadrada(double a, double b, double c)
    {
      var delta = b * b - 4 * a * c;

      var x1 = ((b * -1) + Math.Sqrt(delta)) / 2 * a;

      var x2 = ((b * -1) - Math.Sqrt(delta)) / 2 * a;

      double[] result = new double[2] { x1, x2 };

      return result;

    }
  }
}
