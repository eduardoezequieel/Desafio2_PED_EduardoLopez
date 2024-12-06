using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Grafo<string> grafo = new Grafo<string>();

            // Definición de los vértices
            Vertice<string> Ahuachapan = new Vertice<string>("Ahuachapan", 0, 0);
            Vertice<string> SantaAna = new Vertice<string>("Santa Ana", 0, 0);
            Vertice<string> Sonsonate = new Vertice<string>("Sonsonate", 0, 0);
            Vertice<string> LaLibertad = new Vertice<string>("La Libertad", 0, 0);
            Vertice<string> Chalatenango = new Vertice<string>("Chalatenango", 0, 0);
            Vertice<string> Cuscatlan = new Vertice<string>("Cuscatlan", 0, 0);
            Vertice<string> SanSalvador = new Vertice<string>("San Salvador", 0, 0);
            Vertice<string> LaPaz = new Vertice<string>("La Paz", 0, 0);
            Vertice<string> Cabañas = new Vertice<string>("Cabañas", 0, 0);
            Vertice<string> SanVicente = new Vertice<string>("San Vicente", 0, 0);
            Vertice<string> Usulutan = new Vertice<string>("Usulutan", 0, 0);
            Vertice<string> SanMiguel = new Vertice<string>("San Miguel", 0, 0);
            Vertice<string> Morazan = new Vertice<string>("Morazan", 0, 0);
            Vertice<string> LaUnion = new Vertice<string>("La Union", 0, 0);

            // Agregar vértices al grafo
            grafo.AgregarVertice(Ahuachapan);
            grafo.AgregarVertice(SantaAna);
            grafo.AgregarVertice(Sonsonate);
            grafo.AgregarVertice(LaLibertad);
            grafo.AgregarVertice(Chalatenango);
            grafo.AgregarVertice(Cuscatlan);
            grafo.AgregarVertice(SanSalvador);
            grafo.AgregarVertice(LaPaz);
            grafo.AgregarVertice(Cabañas);
            grafo.AgregarVertice(SanVicente);
            grafo.AgregarVertice(Usulutan);
            grafo.AgregarVertice(SanMiguel);
            grafo.AgregarVertice(Morazan);
            grafo.AgregarVertice(LaUnion);

            // Agregar aristas con sus respectivos pesos (distancias en kilómetros)
            grafo.AgregarArista(Ahuachapan, SantaAna, 34.1);
            grafo.AgregarArista(Ahuachapan, Sonsonate, 44.7);
            grafo.AgregarArista(SantaAna, Sonsonate, 57.9);
            grafo.AgregarArista(SantaAna, LaLibertad, 76.8);
            grafo.AgregarArista(SantaAna, Chalatenango, 97.6);
            grafo.AgregarArista(Sonsonate, LaLibertad, 78.7);
            grafo.AgregarArista(LaLibertad, Chalatenango, 132);
            grafo.AgregarArista(LaLibertad, SanSalvador, 30.9);
            grafo.AgregarArista(LaLibertad, LaPaz, 40.1);
            grafo.AgregarArista(SanSalvador, Chalatenango, 82.9);
            grafo.AgregarArista(SanSalvador, Cuscatlan, 41.6);
            grafo.AgregarArista(SanSalvador, LaPaz, 48.1);
            grafo.AgregarArista(Cuscatlan, Cabañas, 69.9);
            grafo.AgregarArista(Cuscatlan, LaPaz, 80.3);
            grafo.AgregarArista(Cuscatlan, SanVicente, 57.5);
            grafo.AgregarArista(Cuscatlan, Chalatenango, 74.1);
            grafo.AgregarArista(LaPaz, SanVicente, 38.3);
            grafo.AgregarArista(Cabañas, SanVicente, 50.2);
            grafo.AgregarArista(Cabañas, Chalatenango, 51.8);
            grafo.AgregarArista(Cabañas, SanMiguel, 126);
            grafo.AgregarArista(SanVicente, Usulutan, 62.5);
            grafo.AgregarArista(Usulutan, SanMiguel, 51);
            grafo.AgregarArista(SanVicente, SanMiguel, 85.3);
            grafo.AgregarArista(SanMiguel, Morazan, 40.9);
            grafo.AgregarArista(SanMiguel, LaUnion, 45.3);
            grafo.AgregarArista(Morazan, LaUnion, 81.4);

        }

    }
}
