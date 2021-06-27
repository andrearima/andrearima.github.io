namespace Arima.Entidades
{
    public class Funcao
    {
        public Funcao(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get; }
        public string Descricao { get; }
    }
}
