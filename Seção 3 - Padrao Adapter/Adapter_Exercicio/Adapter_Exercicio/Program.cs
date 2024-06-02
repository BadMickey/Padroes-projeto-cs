using Adapter_Exercicio;
public class Program
{
    public static void Main(string[] args)
    {
        IGeraGrafico grafico = new GraficoAdapter();

        grafico.Titulo = "Gerador de gráficos";

        List<string> xvalores = new List<string>();
        xvalores.Add("Seg");
        xvalores.Add("Ter");

        List<int> yvalores = new List<int>();
        yvalores.Add(1);
        yvalores.Add(2);

        grafico.GerarGrafico(grafico.Titulo, xvalores, yvalores);
        Console.ReadKey();
    }
}