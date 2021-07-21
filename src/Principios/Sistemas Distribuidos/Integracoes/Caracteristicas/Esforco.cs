namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Esforco : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Esforço";
        }
        public string Descricao()
        {
            return @"Algumas soluções de integração podem endereçar bem os diversos fatores apresentados, porém, podem ser difíceis de se desenvolver, depurar e manter. Profissionais específicos podem ser necessários para monitorá-las e para gerenciar erros.";
        }
    }
}
