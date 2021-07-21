namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Tecnologia : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Seleção de Tecnologia";
        }
        public string Descricao()
        {
            return @"Diferentes abordagens de integração requerem diferentes quantidades de licenças de software e hardware. Tais ferramentas podem ser caras, podem levar a dependência da organização com fornecedores específicos e ao aumento da curva de aprendizado dos desenvolvedores.";
        }
    }
}
