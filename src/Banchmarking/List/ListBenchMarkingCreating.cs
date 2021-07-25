using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banchmarking.List
{
    [MemoryDiagnoser]
    public class ListBenchMarkingCreating
    {
        private readonly short _quantidadeDeItens;
        public ListBenchMarkingCreating()
        {
            _quantidadeDeItens = 30000;
        }
        [Benchmark]
        public void CriarListaSemPassarQuantidadeDeObjetos()
        {
            var lista = new List<short>();
            for (short i = 0; i <= _quantidadeDeItens; i++)
            {
                lista.Add(i);
            }
        }
        [Benchmark]
        public void CriarListaPassandoQuantidadeDeObjetos()
        {
            var lista = new List<short>(_quantidadeDeItens);
            for (short i = 0; i <= _quantidadeDeItens; i++)
            {
                lista.Add(i);
            }
        }
    }
}
