using Desafio2_PED_EduardoLopez.Helpers;
using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Views
{
    public partial class DashboardView : Form
    {
        private List<string> Countries = new List<string> { "El Salvador", "Guatemala", "Honduras", "Nicaragua", "Costa Rica" };
        private GrafoElSalvador GrafoElSalvador = new GrafoElSalvador();
        private GrafoGuatemala GrafoGuatemala = new GrafoGuatemala();
        private Vertice<string>? verticeOrigen = null;
        private Grafo<string> PaisSeleccionado;


        public DashboardView()
        {
            InitializeComponent();

            this.countryCb.DataSource = Countries;
            PaisSeleccionado = new Grafo<string>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DrawGraph(Grafo<string> country)
        {
            this.countryPanel.Controls.Clear();

            country.Vertices.ForEach(vertice =>
            {
                if (vertice.X == 0 || vertice.Y == 0)
                {
                    return;
                }

                Button button = new Button();
                button.Text = vertice.Valor;
                button.Size = new Size(143, 45);
                button.BackColor = Color.FromArgb(38, 38, 38);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Location = new Point(vertice.X, vertice.Y);

                button.Click += (sender, e) => handleCountryClick(sender, e, vertice);

                this.countryPanel.Controls.Add(button);
            });
        }

        private void handleCountryClick(object sender, EventArgs e, Vertice<string> verticeDestino)
        {
            if (this.verticeOrigen == null)
            {
                this.verticeOrigen = verticeDestino;
                return;
            }
            else if (this.verticeOrigen.Valor.Equals(verticeDestino.Valor))
            {
                MessageBox.Show("No puedes escoger la misma ciudad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.verticeOrigen = null;
                return;
            }

            string input = InputBox.Show("Ingrese la distancia entre las ciudades", "Distancia");
            if (double.TryParse(input, out double distancia))
            {
                this.PaisSeleccionado.AgregarArista(this.verticeOrigen, verticeDestino, distancia);
                this.countryPanel.Invalidate(); // Forzar el repintado del panel
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.verticeOrigen = null;
        }

        private void countryCb_SelectedValueChanged(object sender, EventArgs e)
        {
            string? selectedCountry = countryCb.SelectedItem?.ToString();

            if (selectedCountry == "El Salvador")
                this.PaisSeleccionado = GrafoElSalvador.ElSalvador;
            else if (selectedCountry == "Guatemala")
                this.PaisSeleccionado = GrafoGuatemala.Guatemala;

            this.cityCb.ValueMember = "Valor";
            this.cityCb.DisplayMember = "Valor";
            this.cityCb.DataSource = PaisSeleccionado.Vertices;
            this.DrawGraph(PaisSeleccionado);
        }
    }
}
