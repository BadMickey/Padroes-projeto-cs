using Adapter.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AlunosAdapter : ICalcula
    {
        private SistemaMensalidades sistemaMensalidades = new SistemaMensalidades();
        public void ProcessaCalculaMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno> ();

            ConverteArraytoList(alunosArray, Id, Nome, Mensalidade, listaAlunos);

        }

        private void ConverteArraytoList(string[,] alunosArray, string Id, string Nome, string Mensalidade, List<Aluno> listaAlunos)
        {
            for (int i = 0; i < alunosArray.GetLength (0); i++) 
            { 
                for( int j = 0; j < alunosArray.GetLength (1); j++)
                {
                    if(j == 0)
                    {
                        Id = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Nome = alunosArray[i, j];
                    }
                    else
                    {
                        Mensalidade = alunosArray[i, j];
                    }
                }
                listaAlunos.Add(new Aluno(Convert.ToInt32(Id), Nome, 
                    Convert.ToDecimal(Mensalidade)));
            }
        }
    }
}
