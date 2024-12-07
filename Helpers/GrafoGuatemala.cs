using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers
{
    public class GrafoGuatemala
    {
        public Grafo<string> Guatemala { get; set; }

        public GrafoGuatemala()
        {

            this.Guatemala = new Grafo<string>();

            // Definición de los vértices
            Vertice<string> Peten = new Vertice<string>("Petén", 673, 50);
            Vertice<string> AltaVerapaz = new Vertice<string>("Alta Verapaz", 636, 131);
            Vertice<string> BajaVerapaz = new Vertice<string>("Baja Verapaz", 636, 200);
            Vertice<string> Izabal = new Vertice<string>("Izabal", 864, 131);
            Vertice<string> Zacapa = new Vertice<string>("Zacapa", 1032, 225);
            Vertice<string> Chiquimula = new Vertice<string>("Chiquimula", 1065, 316);
            Vertice<string> Jalapa = new Vertice<string>("Jalapa", 875, 316);
            Vertice<string> Jutiapa = new Vertice<string>("Jutiapa", 965, 421);
            Vertice<string> SantaRosa = new Vertice<string>("Santa Rosa", 722, 487);
            Vertice<string> Escuintla = new Vertice<string>("Escuintla", 518, 454);
            Vertice<string> Guatemala = new Vertice<string>("Guatemala", 673, 279);
            Vertice<string> Chimaltenango = new Vertice<string>("Chimaltenango", 595, 360);
            Vertice<string> Sacatepequez = new Vertice<string>("Sacatepéquez", 764, 396);
            Vertice<string> Solola = new Vertice<string>("Sololá", 412, 326);
            Vertice<string> Quetzaltenango = new Vertice<string>("Quetzaltenango", 222, 301);
            Vertice<string> Totonicapan = new Vertice<string>("Totonicapán", 339, 200);
            Vertice<string> SanMarcos = new Vertice<string>("San Marcos", 90, 231);
            Vertice<string> Huehuetenango = new Vertice<string>("Huehuetenango", 191, 131);
            Vertice<string> Quiche = new Vertice<string>("Quiché", 412, 131);

            this.Guatemala.AgregarVertice(Peten);
            this.Guatemala.AgregarVertice(AltaVerapaz);
            this.Guatemala.AgregarVertice(BajaVerapaz);
            this.Guatemala.AgregarVertice(Izabal);
            this.Guatemala.AgregarVertice(Zacapa);
            this.Guatemala.AgregarVertice(Chiquimula);
            this.Guatemala.AgregarVertice(Jalapa);
            this.Guatemala.AgregarVertice(Jutiapa);
            this.Guatemala.AgregarVertice(SantaRosa);
            this.Guatemala.AgregarVertice(Escuintla);
            this.Guatemala.AgregarVertice(Guatemala);
            this.Guatemala.AgregarVertice(Chimaltenango);
            this.Guatemala.AgregarVertice(Sacatepequez);
            this.Guatemala.AgregarVertice(Solola);
            this.Guatemala.AgregarVertice(Quetzaltenango);
            this.Guatemala.AgregarVertice(Totonicapan);
            this.Guatemala.AgregarVertice(SanMarcos);
            this.Guatemala.AgregarVertice(Huehuetenango);
            this.Guatemala.AgregarVertice(Quiche);
        }
    }
}
