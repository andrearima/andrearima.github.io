namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Escalabilidade : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Escalabilidade";
        }
        public string Descricao()
        {
            return @"Integrações devem causar o mínimo de impacto na performance dos sistemas envolvidos. Também devem ser projetadas para suportar aumento no volume de dados trafegados e ainda pensando-se nos impactos decorrentes de acréscimo no número de sistemas consumidores de uma determinada informação.";
        }
    }
}
