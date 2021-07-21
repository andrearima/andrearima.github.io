using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Patterns
{
    public abstract class ApresentacaoPattern
    {
        private readonly string _nome;
        private readonly string _objetivo;
        private readonly string _motivacao;
        private readonly string _aplicabilidade;
        private readonly string _estrutura;
        private readonly string _consequencias;
        private readonly string _implementacoes;
        private readonly string _casoDeUso;
        private readonly List<string> _padroesRelacionados;

        protected ApresentacaoPattern(string nome, string objetivo, string motivacao, string aplicabilidade, 
            string estrutura, string consequencias, string implementacoes, string casoDeUso, List<string> padroesRelacionados)
        {
            _nome = nome;
            _objetivo = objetivo;
            _motivacao = motivacao;
            _aplicabilidade = aplicabilidade;
            _estrutura = estrutura;
            _consequencias = consequencias;
            _implementacoes = implementacoes;
            _casoDeUso = casoDeUso;
            _padroesRelacionados = padroesRelacionados;
        }

        public virtual string Nome()
        {
            return _nome;
        }
        public virtual string Objetivo()
        {
            return _objetivo;
        }
        public virtual string Motivacao()
        {
            return _motivacao;
        }
        public virtual string Aplicabilidade()
        {
            return _aplicabilidade;
        }
        public virtual string Estrutura()
        {
            return _estrutura;
        }
        public virtual string Consequencias()
        {
            return _consequencias;
        }
        public virtual string Implementacoes()
        {
            return _implementacoes;
        }
        public virtual string CasoDeUso()
        {
            return _casoDeUso;
        }
        public virtual List<string> PadroesRelacionados()
        {
            return _padroesRelacionados;
        }
    }
}
