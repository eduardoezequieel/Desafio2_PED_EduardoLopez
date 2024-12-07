using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers
{
    public class GrafoElSalvador
    {
        public Grafo<string> ElSalvador { get; set; }

        public GrafoElSalvador()
        {
            ElSalvador = new Grafo<string>();

            // Definición de los vértices
            Vertice<string> Ahuachapan = new Vertice<string>("Ahuachapan", 30, 256);
            Vertice<string> SantaAna = new Vertice<string>("Santa Ana", 184, 179);
            Vertice<string> Sonsonate = new Vertice<string>("Sonsonate", 88, 340);
            Vertice<string> LaLibertad = new Vertice<string>("La Libertad", 316, 385);
            Vertice<string> Chalatenango = new Vertice<string>("Chalatenango", 374, 131);
            Vertice<string> Cuscatlan = new Vertice<string>("Cuscatlan", 542, 238);
            Vertice<string> SanSalvador = new Vertice<string>("San Salvador", 374, 293);
            Vertice<string> LaPaz = new Vertice<string>("La Paz", 542, 359);
            Vertice<string> Cabañas = new Vertice<string>("Cabañas", 709, 194);
            Vertice<string> SanVicente = new Vertice<string>("San Vicente", 709, 293);
            Vertice<string> Usulutan = new Vertice<string>("Usulutan", 866, 369);
            Vertice<string> SanMiguel = new Vertice<string>("San Miguel", 987, 293);
            Vertice<string> Morazan = new Vertice<string>("Morazan", 1056, 179);
            Vertice<string> LaUnion = new Vertice<string>("La Union", 1168, 349);

            // Agregar vértices al grafo
            ElSalvador.AgregarVertice(Ahuachapan);
            ElSalvador.AgregarVertice(SantaAna);
            ElSalvador.AgregarVertice(Sonsonate);
            ElSalvador.AgregarVertice(LaLibertad);
            ElSalvador.AgregarVertice(Chalatenango);
            ElSalvador.AgregarVertice(Cuscatlan);
            ElSalvador.AgregarVertice(SanSalvador);
            ElSalvador.AgregarVertice(LaPaz);
            ElSalvador.AgregarVertice(Cabañas);
            ElSalvador.AgregarVertice(SanVicente);
            ElSalvador.AgregarVertice(Usulutan);
            ElSalvador.AgregarVertice(SanMiguel);
            ElSalvador.AgregarVertice(Morazan);
            ElSalvador.AgregarVertice(LaUnion);
        }
    }
}
