namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Formato : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Formato";
        }
        public string Descricao()
        {
            return @"Para se integrarem, aplicações devem concordar em um formato de dado. Considerando que alterar todas as aplicações da organização para considerar um formato de dado único pode ser inviável, tradutores intermediários podem ser empregados. Outro assunto relacionado é como a evolução do formato do dado ao longo do tempo pode impactar as aplicações dependentes.";
        }
    }
}
