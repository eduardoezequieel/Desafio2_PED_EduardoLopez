namespace Desafio2_PED_EduardoLopez.Models
{
    public class Grafo<T>
    {
        public List<Vertice<T>> Vertices { get; set; }

        public Grafo()
        {
            Vertices = new List<Vertice<T>>();
        }

        public void AgregarVertice(Vertice<T> vertice)
        {
            Vertices.Add(vertice);
        }

        public void AgregarArista(Vertice<T> origen, Vertice<T> destino, double distancia)
        {
            origen.Aristas.Add(new Arista<T>(destino, distancia));
        }
    }
}
