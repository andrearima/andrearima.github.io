namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Funcionalidades : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Exposição de Funcionalidades";
        }
        public string Descricao()
        {
            return @"Muitas abordagens de integrações permitem que aplicações compartilhem não apenas dados, mas também funcionalidades. Tal compartilhamento é interessante, pois gera um nível maior de abstração entre as aplicações envolvidas.";
        }
    }
}
