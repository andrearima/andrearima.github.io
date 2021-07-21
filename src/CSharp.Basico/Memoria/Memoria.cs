namespace CSharp.Basico.Memoria
{
    public sealed class Memoria : IMemoria
    {
        //a stack tem os ponteiros para acessar a heap.
        public Stack Stack { get; set; }
    }
}