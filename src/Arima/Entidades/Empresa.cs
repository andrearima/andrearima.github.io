using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima
{
    public class Empresa
    {
        public Empresa(string nome, string ramo, string descricao, string urlSite)
        {
            Nome = nome;
            Ramo = ramo;
            Descricao = descricao;
            UrlSite = urlSite;
        }

        public string Nome { get; private set; }
        public string Ramo { get; private set; }
        public string Descricao { get; private set; }
        public string UrlSite { get; private set; }
    }
}
