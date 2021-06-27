using Arima.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima
{
    public class Profissao
    {
        public Profissao(List<Funcao> funcoes, string descricao, DateTime dataInicio, DateTime? dataTermino, Empresa empresa)
        {
            Funcoes = funcoes;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Empresa = empresa;
        }
        public Profissao(string nomeFuncao,string descricaoFuncao, string descricao, DateTime dataInicio, DateTime? dataTermino, Empresa empresa)
        {
            Funcoes = new List<Funcao> { new Funcao(nomeFuncao, descricaoFuncao) };
            Descricao = descricao;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Empresa = empresa;
        }
        public List<Funcao> Funcoes { get; private set}
        public string Descricao { get; }
        public DateTime DataInicio { get; }
        public DateTime? DataTermino { get; }
        public Empresa Empresa { get; }
    }
}
