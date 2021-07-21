namespace CSharp.Basico.ModificadorAcesso
{
    public class Calling
    {
        /// <summary>
        /// exemplicação de metoos acessiveis dentro do mesmo projeto / assembly
        /// </summary>
        private void MakeDemoCalls()
        {
            Access access = new Access();
            access.InternalDemo();
            access.ProtectedInternal();
            access.Public();
        }
    }
}
