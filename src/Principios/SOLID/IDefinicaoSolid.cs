namespace Principios.SOLID
{
    public interface IDefinicaoSolid
    {
        string Letra();
        string Sigla();
        string Nome();
        string Definicao();
        IDefinicaoSolid PrincipioFactory(string Sigla);
    }
}
