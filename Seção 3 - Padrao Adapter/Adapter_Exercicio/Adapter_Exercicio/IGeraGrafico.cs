using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exercicio
{
    public interface IGeraGrafico
    {
        string Titulo { get; set; }
        List<string> Xvalores { get; set; }
        List<int> Yvalores { get; set; }

        void GerarGrafico(string titulo, List<string> x, List<int> y);
    }
}
