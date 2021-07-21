namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Intrusividade : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Intrusividade";
        }
        public string Descricao()
        {
            return @"Integrações devem causar o mínimo de impacto em códigos existentes e devem requerer pouca codificação.";
        }
    }
}
