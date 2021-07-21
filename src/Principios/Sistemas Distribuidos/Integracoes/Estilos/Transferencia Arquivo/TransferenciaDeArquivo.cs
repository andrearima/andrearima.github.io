namespace Principios.Sistemas_Distribuidos.Integracoes.Estilos
{
    public class TransferenciaDeArquivo : IEstiloDeIntegracao
    {
        public string Nome()
        {
            return "Transferência de Arquivo";
        }
        public string Descricao()
        {
            return "Um sistema escreve um arquivo texto ou binário para que outro sistema leia.";
        }
    }
}
