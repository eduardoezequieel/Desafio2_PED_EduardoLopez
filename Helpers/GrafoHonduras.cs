using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers
{
    public class GrafoHonduras
    {
        public Grafo<string> Honduras { get; set; }

        public GrafoHonduras()
        {
            Honduras = new Grafo<string>();

            Vertice<string> Ocotepeque = new Vertice<string>("Ocotepeque", 28, 334);
            Vertice<string> Copan = new Vertice<string>("Copán", 82, 263);
            Vertice<string> Lempira = new Vertice<string>("Lempira", 148, 407);
            Vertice<string> SantaBarbara = new Vertice<string>("Santa Bárbara", 217, 198);
            Vertice<string> Intibuca = new Vertice<string>("Intibucá", 293, 346);
            Vertice<string> LaPaz = new Vertice<string>("La Paz", 379, 428);
            Vertice<string> Comayagua = new Vertice<string>("Comayagua", 456, 280);
            Vertice<string> Cortes = new Vertice<string>("Cortés", 379, 140);
            Vertice<string> Yoro = new Vertice<string>("Yoro", 580, 198);
            Vertice<string> Atlantida = new Vertice<string>("Atlántida", 580, 120);
            Vertice<string> FranciscoMorazan = new Vertice<string>("Francisco Morazán", 638, 346);
            Vertice<string> Choluteca = new Vertice<string>("Choluteca", 638, 537);
            Vertice<string> ElParaiso = new Vertice<string>("El Paraíso", 798, 458);
            Vertice<string> Olancho = new Vertice<string>("Olancho", 874, 263);
            Vertice<string> IslasdeLaBahia = new Vertice<string>("Islas de la Bahía", 818, 51);
            Vertice<string> Colon = new Vertice<string>("Colón", 940, 120);
            Vertice<string> GraciasaDios = new Vertice<string>("Gracias a Dios", 1147, 152);
            Vertice<string> Valle = new Vertice<string>("Valle", 456, 497);


            Honduras.AgregarVertice(Ocotepeque);
            Honduras.AgregarVertice(Copan);
            Honduras.AgregarVertice(Lempira);
            Honduras.AgregarVertice(SantaBarbara);
            Honduras.AgregarVertice(Intibuca);
            Honduras.AgregarVertice(LaPaz);
            Honduras.AgregarVertice(Comayagua);
            Honduras.AgregarVertice(Cortes);
            Honduras.AgregarVertice(Yoro);
            Honduras.AgregarVertice(Atlantida);
            Honduras.AgregarVertice(FranciscoMorazan);
            Honduras.AgregarVertice(Choluteca);
            Honduras.AgregarVertice(ElParaiso);
            Honduras.AgregarVertice(Olancho);
            Honduras.AgregarVertice(IslasdeLaBahia);
            Honduras.AgregarVertice(Colon);
            Honduras.AgregarVertice(GraciasaDios);
            Honduras.AgregarVertice(Valle);
        }
    }
}
