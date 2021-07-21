namespace Principios.Sistemas_Distribuidos.Integracoes.Estilos
{
    public class Mensageria : IEstiloDeIntegracao
    {
        public string Nome()
        {
            return "Mensageria";
        }
        public string Descricao()
        {
            return "As aplicações se conectam a um sistema comum e intermediário de mensageria conhecido como MOM, de forma a compartilhar dados e a invocar operações através do uso de mensagens.";
        }
        public string Pattern()
        {
            return "Mediator Pattern";
        }
    }
}
