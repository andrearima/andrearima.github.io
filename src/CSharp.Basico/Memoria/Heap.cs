using CSharp.Basico.Variaveis;
using System.Collections.Generic;

namespace CSharp.Basico.Memoria
{
    public class Heap : IMemoria
    {
        public string Size = "Grande";
        public string Custo = "Maior que Stack";
        public string Funcionamento = "";
        public string Excessao = "";
        public string NomeTipos = "Reference Types";
        public List<string> Tipos = new() { "Classes", "Interfaces", "Delegates" };

        public List<ReferenceTypes> ReferenteTypes { get; set; }
    }
}