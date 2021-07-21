using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Patterns
{
    public class DesignPattern
    {
        private List<string> _beneficios;
        private List<string> _gof;
        public DesignPattern()
        {
            _beneficios = new List<string>
            {
                "Fornecem soluções que já foram testadas e aprovadas",
                "Tornam o sistema mais fácil de entender e manter",
                "Facilitam o desenvolvimento de módulos coesos",
                "A comunicação entre os participantes do projeto fica mais eficiente"
            };

            _gof = new List<string>
            {
                "Ralph Johson",
                "Erich Gamma",
                "Richard Helm",
                "Joshn Vlissides"
            };
        }
        public List<string> Beneficios => _beneficios;
        public List<string> Autores => _gof;
    }
    public interface ICreational { }
    public interface IStructural { }
    public interface IBehavioral { }

}
