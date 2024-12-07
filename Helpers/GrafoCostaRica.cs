using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers
{
    public class GrafoCostaRica
    {
        public Grafo<string> CostaRica { get; set; }

        public GrafoCostaRica()
        {
            CostaRica = new Grafo<string>();


            Vertice<string> SanJose = new Vertice<string>("San José", 455, 329);     
            Vertice<string> Alajuela = new Vertice<string>("Alajuela", 340, 128);    
            Vertice<string> Heredia = new Vertice<string>("Heredia", 580, 180);      
            Vertice<string> Cartago = new Vertice<string>("Cartago", 677, 294);      
            Vertice<string> Guanacaste = new Vertice<string>("Guanacaste", 100, 180);
            Vertice<string> Puntarenas = new Vertice<string>("Puntarenas", 900, 450);
            Vertice<string> Limon = new Vertice<string>("Limón", 910, 358);          


            CostaRica.AgregarVertice(SanJose);
            CostaRica.AgregarVertice(Alajuela);
            CostaRica.AgregarVertice(Heredia);
            CostaRica.AgregarVertice(Cartago);
            CostaRica.AgregarVertice(Guanacaste);
            CostaRica.AgregarVertice(Puntarenas);
            CostaRica.AgregarVertice(Limon);

            
        }
    }
}
