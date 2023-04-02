using System.Text;
using algoritmos;

//Dados para testes
int[] valores = GerarDados.GerarInteiros(1, 50, 20);
StringBuilder mostrarValores = new StringBuilder();
foreach (var item in valores)
{
  mostrarValores.Append($"{item.ToString()} ");
}
//valores = valores.Order().ToArray();
System.Console.WriteLine($"Os valores são: {mostrarValores.ToString()}");

//Pesquisa Binária
// System.Console.WriteLine(PesquisaBinaria.Resultado(valores, 2));

//Ordenar Por Seleção
// System.Console.WriteLine(OrdenarPorSelecao.OrdenacaoPorSelecao(valores));

//Recursão
// System.Console.WriteLine(Recursao.Regressiva(10));
// var recursao = new Recursao();
// System.Console.WriteLine($"O menor valor é: {recursao.MenorNumero(valores)}");

//Pesquisa Binária Dividir para comquistar
// var rnd = new Random();
// var valor = rnd.Next(1, 1500);
// System.Console.WriteLine($"O valor é {valor}. Encontrado: {PesquisaBinariaDividirParaConquistar.Resultado(valores, valor)}");

//Quicksort
System.Console.WriteLine(string.Join(",", Quicksort.Resultado(valores)));