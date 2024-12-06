namespace Desafio2_PED_EduardoLopez.Models
{
    public class Arista<T>
    {
        public Vertice<T> Destino { get; set; }
        public double Distancia { get; set; }

        public Arista(Vertice<T> destino, double distancia)
        {
            Destino = destino;
            Distancia = distancia;
        }
    }
}
