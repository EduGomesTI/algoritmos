namespace Capitulo_2
{
  public static class Problema_01
  {
    public static int Calcular_Vertice(int faces, int arestas)
    {
      var vertices = arestas + 2 - faces;

      return vertices;
    }
  }
}
