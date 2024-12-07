using Desafio2_PED_EduardoLopez.Helpers;
using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Views
{
    public partial class DashboardView : Form
    {
        private List<string> Countries = new List<string> { "El Salvador", "Guatemala", "Honduras", "Nicaragua", "Costa Rica" };
        private List<string> Recorridos = new List<string> { "Anchura", "Profundidad" };
        private GrafoElSalvador GrafoElSalvador = new GrafoElSalvador();
        private GrafoGuatemala GrafoGuatemala = new GrafoGuatemala();
        private GrafoHonduras GrafoHonduras = new GrafoHonduras();
        private GrafoCostaRica GrafoCostaRica = new GrafoCostaRica();
        private Vertice<string>? verticeOrigen = null;
        private Grafo<string> PaisSeleccionado;
        int buttonWidth = 143;
        int buttonHeight = 45;


        public DashboardView()
        {
            InitializeComponent();

            this.countryCb.DataSource = Countries;
            this.cbType.DataSource = Recorridos;
            this.PaisSeleccionado = GrafoElSalvador.ElSalvador;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DrawGraph()
        {
            this.countryPanel.Controls.Clear();

            this.PaisSeleccionado.Vertices.ForEach(vertice =>
            {
                if (vertice.X == 0 || vertice.Y == 0)
                {
                    return;
                }

                Button button = new Button();
                button.Text = vertice.Valor;
                button.Size = new Size(this.buttonWidth, this.buttonHeight);
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

            bool aristaExiste = this.verticeOrigen.Aristas.Any(a => a.Destino.Equals(verticeDestino)) ||
                                verticeDestino.Aristas.Any(a => a.Destino.Equals(this.verticeOrigen));

            if (aristaExiste)
            {
                MessageBox.Show("La arista ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.verticeOrigen = null;
                return;
            }


            string input = InputBox.Show("Ingrese la distancia entre las ciudades", "Distancia");
            if (double.TryParse(input, out double distancia))
            {
                this.PaisSeleccionado.AgregarArista(this.verticeOrigen, verticeDestino, distancia);
                this.countryPanel.Invalidate();
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
            else if (selectedCountry == "Honduras")
                this.PaisSeleccionado = GrafoHonduras.Honduras;
            else if (selectedCountry == "Costa Rica")
                this.PaisSeleccionado = GrafoCostaRica.CostaRica;

            this.cityCb.ValueMember = "Valor";
            this.cityCb.DisplayMember = "Valor";
            this.cityCb.DataSource = PaisSeleccionado.Vertices;
            this.DrawGraph();


        }

        private void drawAristas(Graphics graphics)
        {
            int midWidth = this.buttonWidth / 2;
            int midHeight = this.buttonHeight / 2;

            this.PaisSeleccionado.Vertices.ForEach(vertice =>
            {
                vertice.Aristas.ForEach(arista =>
                {
                    Point origen = new Point(vertice.X + midWidth, vertice.Y + midHeight);
                    Point destino = new Point(arista.Destino.X + midWidth, arista.Destino.Y + midHeight);

                    arista.Distancia = Math.Round(arista.Distancia, 2);

                    // Dibujar la línea
                    graphics.DrawLine(new Pen(Color.White, 2), origen, destino);

                    // Calcular el punto medio de la línea
                    Point puntoMedio = new Point((origen.X + destino.X) / 2, (origen.Y + destino.Y) / 2);

                    // Dibujar la distancia en el punto medio
                    string distanciaTexto = arista.Distancia.ToString() + " km";
                    Font font = new Font("Arial", 10);
                    Brush brush = new SolidBrush(Color.LemonChiffon);
                    graphics.DrawString(distanciaTexto, font, brush, puntoMedio);
                });
            });
        }

        private void countryPanel_Paint(object sender, PaintEventArgs e)
        {
            this.drawAristas(e.Graphics);
        }

        private async void btnContinue_Click(object sender, EventArgs e)
        {
            string? recorridoSeleccionado = cbType.SelectedItem?.ToString();
            Vertice<string>? verticeInicial = this.PaisSeleccionado.Vertices.FirstOrDefault(v => v.Valor == cityCb.Text);

            if (verticeInicial == null)
            {
                MessageBox.Show("Seleccione un vértice de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.PaisSeleccionado == null)
            {
                MessageBox.Show("Contacte al administrador del sistema");
                return;
            }

            if (recorridoSeleccionado == "Anchura")
            {
                Anchura anchura = new Anchura();
                await anchura.Recorrer(this.PaisSeleccionado, verticeInicial, this.countryPanel, this.buttonWidth, this.buttonHeight);

                await Task.Delay(1000);
                this.drawAristas(this.countryPanel.CreateGraphics());
            }
            else if (recorridoSeleccionado == "Profundidad")
            {
                Profundidad profundidad = new Profundidad();
                await profundidad.Recorrer(this.PaisSeleccionado, verticeInicial, this.countryPanel, this.buttonWidth, this.buttonHeight);
                await Task.Delay(1000);
                this.drawAristas(this.countryPanel.CreateGraphics());
            }
        }

        private void btnDeleteAristas_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar todas las aristas ? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.PaisSeleccionado.Vertices.ForEach(vertice =>
                {
                    vertice.Aristas.Clear();
                });
                this.countryPanel.Invalidate();
            }

        }
    }
}
