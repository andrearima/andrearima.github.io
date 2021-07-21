using System.Collections.Generic;

namespace CSharp.Basico.Memoria
{
    public class Stack : IMemoria
    {
        public string Size = "Pequeno";
        public string Funcionamento = "Pilha = Stack = LIFO (Last In First Out)";
        public string Excessao = "Stack Over Flow";
        public string NomeTipos = "System.ValueType";
        public List<string> Tipos = new() { "int", "long", "short", "float", "double", "decimal", "bool", "struct" };


        private Heap Heap;
        public object GetHeapObject(object obj)
        {
            return Heap.ReferenteTypes.Find(x => x.Equals(obj));
        }
    }
}