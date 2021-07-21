namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Confiabilidade : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Confiabilidade";
        }
        public string Descricao()
        {
            return @"Conexões remotas não são apenas lentas, mas também são muito menos confiáveis do que a execução de procedimentos locais. Aplicações remotas podem não estar disponíveis ou a rede pode estar temporariamente indisponível. Comunicações assíncronas e confiáveis permitem que a aplicação origem realize outras tarefas, de forma confiante que a aplicação destino receberá a informação.";
        }
    }
}
