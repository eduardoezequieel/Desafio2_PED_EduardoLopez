using Desafio2_PED_EduardoLopez.Models;

namespace Desafio2_PED_EduardoLopez.Helpers;
public class Anchura
{
    public async Task Recorrer(Grafo<string> grafo, Vertice<string> verticeInicial, PictureBox pictureBox, int buttonWidth, int buttonHeight)
    {
        if (verticeInicial == null)
        {
            MessageBox.Show("Seleccione un vértice de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int midWidth = buttonWidth / 2;
        int midHeight = buttonHeight / 2;

        HashSet<Vertice<string>> visitados = new HashSet<Vertice<string>>();
        Queue<Vertice<string>> cola = new Queue<Vertice<string>>();
        HashSet<(Vertice<string>, Vertice<string>)> aristasDibujadas = new HashSet<(Vertice<string>, Vertice<string>)>();

        visitados.Add(verticeInicial);
        cola.Enqueue(verticeInicial);

        while (cola.Count > 0)
        {
            Vertice<string> verticeActual = cola.Dequeue();
            Console.WriteLine(verticeActual.Valor);

            foreach (Arista<string> arista in verticeActual.Aristas)
            {
                Vertice<string> vecino = arista.Destino;

                // Verificar si la arista ya ha sido dibujada
                if (aristasDibujadas.Contains((verticeActual, vecino)) || aristasDibujadas.Contains((vecino, verticeActual)))
                {
                    continue;
                }

                // Dibujar la arista con un retraso
                await Task.Delay(500);
                pictureBox.Invoke((Action)(() =>
                {
                    using (Graphics graphics = pictureBox.CreateGraphics())
                    {
                        Point origen = new Point(verticeActual.X + midWidth, verticeActual.Y + midHeight);
                        Point destino = new Point(vecino.X + midWidth, vecino.Y + midHeight);
                        arista.Distancia = Math.Round(arista.Distancia, 2);

                        graphics.DrawLine(new Pen(Color.Red, 2), origen, destino);
                    }
                }));

                // Marcar la arista como dibujada
                aristasDibujadas.Add((verticeActual, vecino));

                if (!visitados.Contains(vecino))
                {
                    visitados.Add(vecino);
                    cola.Enqueue(vecino);
                }
            }
        }
    }
}

