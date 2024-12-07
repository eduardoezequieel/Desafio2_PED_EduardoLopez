using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers
{
    public class GrafoGuatemala
    {
        public Grafo<string> Guatemala { get; set; }

        public GrafoGuatemala()
        {
            Guatemala = new Grafo<string>();

            // Definición de los vértices
            Vertice<string> CiudadGuatemala = new Vertice<string>("Ciudad de Guatemala", 402, 369);
            Vertice<string> Antigua = new Vertice<string>("Antigua", 0, 0);
            Vertice<string> Quetzaltenango = new Vertice<string>("Quetzaltenango", 0, 0);
            Vertice<string> Escuintla = new Vertice<string>("Escuintla", 0, 0);
            Vertice<string> Coban = new Vertice<string>("Coban", 0, 0);
            Vertice<string> Huehuetenango = new Vertice<string>("Huehuetenango", 0, 0);
            Vertice<string> PuertoBarrios = new Vertice<string>("Puerto Barrios", 0, 0);
            Vertice<string> Flores = new Vertice<string>("Flores", 0, 0);
            Vertice<string> Chiquimula = new Vertice<string>("Chiquimula", 0, 0);
            Vertice<string> Jalapa = new Vertice<string>("Jalapa", 0, 0);
            Vertice<string> Jutiapa = new Vertice<string>("Jutiapa", 0, 0);
            Vertice<string> Zacapa = new Vertice<string>("Zacapa", 0, 0);
            Vertice<string> Retalhuleu = new Vertice<string>("Retalhuleu", 0, 0);
            Vertice<string> SanMarcos = new Vertice<string>("San Marcos", 0, 0);

            // Agregar vértices al grafo
            Guatemala.AgregarVertice(CiudadGuatemala);
            Guatemala.AgregarVertice(Antigua);
            Guatemala.AgregarVertice(Quetzaltenango);
            Guatemala.AgregarVertice(Escuintla);
            Guatemala.AgregarVertice(Coban);
            Guatemala.AgregarVertice(Huehuetenango);
            Guatemala.AgregarVertice(PuertoBarrios);
            Guatemala.AgregarVertice(Flores);
            Guatemala.AgregarVertice(Chiquimula);
            Guatemala.AgregarVertice(Jalapa);
            Guatemala.AgregarVertice(Jutiapa);
            Guatemala.AgregarVertice(Zacapa);
            Guatemala.AgregarVertice(Retalhuleu);
            Guatemala.AgregarVertice(SanMarcos);

        }
    }
}
