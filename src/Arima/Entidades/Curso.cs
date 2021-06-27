using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima
{
    public class Curso
    {
        public Curso(string nome, string descricao, DateTime dataInicio, DateTime? dataFinal, string urlCertificado, Empresa empresa)
        {
            Nome = nome;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            UrlCertificado = urlCertificado;
            Empresa = empresa;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFinal { get; private set; }
        public string UrlCertificado { get; private set; }
        public Empresa Empresa { get; set; }
    }
}
