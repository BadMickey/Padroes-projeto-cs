using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exercicio
{
    public class GraficoAdapter : IGeraGrafico
    {
        public string Titulo { get; set; }
        public List<string> Xvalores { get; set; }
        public List<int> Yvalores { get; set; }

        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            SuperGeradorGrafico grafico = new SuperGeradorGrafico();
            grafico.DesenharGrafico(titulo, x, y);
        }
    }
}
