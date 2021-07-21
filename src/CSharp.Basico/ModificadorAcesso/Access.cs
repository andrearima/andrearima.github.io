namespace CSharp.Basico.ModificadorAcesso
{
    public class Access
    {
        /// <summary>
        /// Acessivel somente nessa classe.
        /// Somente itens de dentro da propria classe pode acessar
        /// não é acessivel em outro assembly neim do mesmo assembly.
        /// </summary>
        private void Private()
        {
            System.Console.WriteLine("Só posso acessar dentro da classe");
        }
        private protected void PrivateProtectedDemo()
        {

        }
        /// <summary>
        /// Usado muito em heranças.
        /// OU seja, classes que herda essa "ACCESS" terá acesso a este metodo
        /// </summary>
        protected void Protected()
        {

        }
        protected internal void ProtectedInternal()
        {

        }

        /// <summary>
        /// Abrange todo o escopo do Projeto / Assembly
        /// </summary>
        internal void InternalDemo()
        {
            System.Console.WriteLine("Só posso acessar dentro do Projeto");
        }
        /// <summary>
        /// acessivel em qualquer lugar
        /// </summary>
        public void Public()
        {
            System.Console.WriteLine("Posso ser acessado em qualquer lugar");
        }
    }
}
