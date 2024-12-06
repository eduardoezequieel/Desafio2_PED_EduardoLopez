namespace Desafio2_PED_EduardoLopez.Models
{
    public class Vertice<T>
    {
        public T Valor { get; set; }
        public List<Arista<T>> Aristas { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Vertice(T valor, int x, int y)
        {
            Valor = valor;
            Aristas = new List<Arista<T>>();
            X = x;
            Y = y;
        }
    }
}
