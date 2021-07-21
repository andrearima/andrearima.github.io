namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Atualizacao : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Tempo para atualização";
        }
        public string Descricao()
        {
            return @"Integrações devem ser estruturadas pensando na minimização do tempo de defasagem de dado. Idealmente, aplicações consumidoras de dado deveriam ser informadas assim que o dado estivesse pronto para consumo. Quanto mais tempo se leva para o compartilhamento do dado, maior a probabilidade de falta de sincronismo de dados.";
        }
    }
}
