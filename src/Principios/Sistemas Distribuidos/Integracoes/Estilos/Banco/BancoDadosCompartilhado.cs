namespace Principios.Sistemas_Distribuidos.Integracoes.Estilos
{
    public class BancoDadosCompartilhado : IEstiloDeIntegracao
    {
        public string Nome()
        {
            return "Banco de Dados Compartilhado";
        }
        public string Descricao()
        {
            return "Múltiplos sistemas utilizam o mesmo banco de dados físicos para consultar e manipular dados.";
        }
    }
}
