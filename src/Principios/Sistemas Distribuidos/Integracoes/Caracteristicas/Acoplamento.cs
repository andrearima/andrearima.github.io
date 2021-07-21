namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Acoplamento : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Acoplamento";
        }
        public string Descricao()
        {
            return @"Aplicações integradas devem minimizar as dependências entre si, de forma que cada uma possa evoluir sem causar problemas para as demais. 
                    Integrações devem ser específicas o suficiente para cumprir seu papel, 
                    porém, genéricas o suficiente para garantir que mudanças não façam com que as aplicações dependentes parem.";
        }
    }
}
