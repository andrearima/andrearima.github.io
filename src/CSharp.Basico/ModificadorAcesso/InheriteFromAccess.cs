namespace CSharp.Basico.ModificadorAcesso
{
    public class InheriteFromAccess : Access
    {
        public void Teste()
        {
            /// metodo herdado
            Protected();
            //acessa pois herda e está dentro do mesmo assembly
            ProtectedInternal();
            Public();
        }
    }
}
