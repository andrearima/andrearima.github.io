namespace Arima
{
    public class Formacao
    {
        public Formacao(string nomeFormacao, string tipoFormacao, string nomeInstituicao, string conclusao, string premio)
        {
            NomeFormacao = nomeFormacao;
            TipoFormacao = tipoFormacao;
            NomeInstituicao = nomeInstituicao;
            Conclusao = conclusao;
            Premio = premio;
        }

        public string NomeFormacao { get; }
        public string TipoFormacao { get; }
        public string NomeInstituicao { get; }
        public string Conclusao { get; }
        public string Premio { get; }
    }
}