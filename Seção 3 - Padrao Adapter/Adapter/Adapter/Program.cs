using Adapter;

public class Program
{
    private static void Main(string[] args)
    {
        var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();

        ICalcula calculo = new AlunosAdapter();

        calculo.ProcessaCalculaMensalidade(alunosArray);            

        Console.ReadKey();
    }
}