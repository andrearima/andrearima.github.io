namespace Principios.Sistemas_Distribuidos.Integracoes.Estilos
{
    public class InvocacaoRemota : IEstiloDeIntegracao
    {
        public string Nome()
        {
            return "Invocação Remota";
        }
        public string Descricao()
        {
            return "Um sistema expõe dados e funcionalidades para que sejam acessadas remotamente por outro sistema através de uso de tecnologias e protocolos proprietário ou públicos.";
        }
    }
}
