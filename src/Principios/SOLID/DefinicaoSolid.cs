using System;

namespace Principios.SOLID
{
    public class DefinicaoSolid : IDefinicaoSolid
    {
        private readonly string _letra;
        private readonly string _sigla;
        private readonly string _nome;
        private readonly string _definicao;
        protected DefinicaoSolid(string letra, string sigla, string nome, string definicao)
        {
            _letra = letra;
            _sigla = sigla;
            _nome = nome;
            _definicao = definicao;
        }
        public string Definicao()
        {
            return _definicao;
        }
        public string Letra()
        {
            return _letra;
        }
        public string Nome()
        {
            return _nome;
        }
        public string Sigla()
        {
            return _sigla;
        }
        public IDefinicaoSolid PrincipioFactory(string Sigla)
        {
            if (string.IsNullOrEmpty(Sigla)) throw new Exception("Informe uma sigla");
            if (Sigla.Length > 1) throw new Exception("A sigla deve conter apenas uma letra: S O L I D."); ;

            return Sigla switch
            {
                "S" => new Srp(),
                "O" => new Ocp(),
                "L" => new LSP(),
                "I" => new ISP(),
                "D" => new DIP(),
                _ => throw new Exception("A sigla informada é invalida! S O L I D"),
            };
        }
    }
}
