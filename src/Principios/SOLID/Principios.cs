namespace Principios.SOLID
{
    public class Srp : DefinicaoSolid
    {
        public Srp() : base("S", "SRP", "Princípio da Responsabilidade Única", "Uma classe deve ter um, e somente um, motivo para mudar.") { }
    }
    public class Ocp : DefinicaoSolid
    {
        public Ocp() : base("O", "OCP", "Princípio Aberto-Fechado", "Você deve ser capaz de estender um comportamento de uma classe, sem modificá-lo.") { }
    }
    public class LSP : DefinicaoSolid
    {
        public LSP() : base("L", "LSP", "Princípio da Substituição de Liskov", "As classes base devem ser substiuíveis por suas classes derivadas.") { }
    }
    public class ISP : DefinicaoSolid
    {
        public ISP() : base("I", "ISP", "Princípio da Segregação da Interface", "Muitas interfaces específicas são melhores do que uma interface única.") { }
    }
    public class DIP : DefinicaoSolid
    {
        public DIP() : base("D", "DIP", "Princípio da inversão da dependência", "Dependa de uma abstração e não de uma implementação.") { }
    }
}
