using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers
{
    public class GrafoNicaragua
    {
        public Grafo<string> Nicaragua { get; set; }
        public GrafoNicaragua()
        {
            Nicaragua = new Grafo<string>();

            Vertice<string> NuevaSegovia = new Vertice<string>("Nueva Segovia", 312, 27);
            Vertice<string> Madriz = new Vertice<string>("Madriz", 268, 100);
            Vertice<string> Esteli = new Vertice<string>("Estelí", 302, 191);
            Vertice<string> Chinandega = new Vertice<string>("Chinandega", 111, 172);
            Vertice<string> Leon = new Vertice<string>("León", 199, 264);
            Vertice<string> Managua = new Vertice<string>("Managua", 380, 332);
            Vertice<string> Masaya = new Vertice<string>("Masaya", 535, 392);
            Vertice<string> Granada = new Vertice<string>("Granada", 613, 458);
            Vertice<string> Jinotega = new Vertice<string>("Jinotega", 471, 125);
            Vertice<string> Jinotepe = new Vertice<string>("Jinotepe", 441, 458);
            Vertice<string> Matagalpa = new Vertice<string>("Matagalpa", 471, 232);
            Vertice<string> Boaco = new Vertice<string>("Boaco", 596, 311);
            Vertice<string> Cortes = new Vertice<string>("Cortés", 684, 530);
            Vertice<string> Chontales = new Vertice<string>("Chontales", 764, 363);
            Vertice<string> RioSanJuan = new Vertice<string>("Río San Juan", 880, 542);
            Vertice<string> RAAN = new Vertice<string>("RAAN", 764, 76);
            Vertice<string> RAAS = new Vertice<string>("RAAS", 932, 288);


            Nicaragua.AgregarVertice(NuevaSegovia);
            Nicaragua.AgregarVertice(Cortes);
            Nicaragua.AgregarVertice(Madriz);
            Nicaragua.AgregarVertice(Esteli);
            Nicaragua.AgregarVertice(Chinandega);
            Nicaragua.AgregarVertice(Leon);
            Nicaragua.AgregarVertice(Managua);
            Nicaragua.AgregarVertice(Masaya);
            Nicaragua.AgregarVertice(Granada);
            Nicaragua.AgregarVertice(Jinotega);
            Nicaragua.AgregarVertice(Matagalpa);
            Nicaragua.AgregarVertice(Boaco);
            Nicaragua.AgregarVertice(Chontales);
            Nicaragua.AgregarVertice(RioSanJuan);
            Nicaragua.AgregarVertice(RAAN);
            Nicaragua.AgregarVertice(RAAS);
        }
    }
}
