namespace Principios.Sistemas_Distribuidos.Integracoes.Caracteristicas
{
    public class Assincrono : ICaracteristicaDaIntegracao
    {
        public string Nome()
        {
            return "Processamento Assíncrono";
        }
        public string Descricao()
        {
            return @"A chamada de funcionalidades remotas de forma síncrona pode ser algo custoso para a aplicação consumidora. A capacidade de realizar tarefas assíncronas traz diversas vantagens como, por exemplo, escalabilidade. Porém, tal solução tem design, desenvolvimento e depuração mais complexos.";
        }
    }
}
