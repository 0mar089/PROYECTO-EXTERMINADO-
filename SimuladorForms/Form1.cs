using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDeVuelos;
using Avion;
using Sector;
using System.Collections;


namespace SimuladorForms
{
    public partial class Form1 : Form
    {
        PictureBox[] aircraft_vector;
        const int MAX = 1000;
        CListaDeVuelos lista = new CListaDeVuelos();

        CAvion[] vuelos;


        public Form1()
        {
            InitializeComponent();
            ResetListaAviones();
            CargarAviones();

            vuelos = lista.GetLista();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void ResetListaAviones()
        {
            aircraft_vector = new PictureBox[5];
      
            for (int i = 0; i < 5; i++)
            {
                aircraft_vector[i] = new PictureBox();
                aircraft_vector[i].ClientSize = new Size(20, 20);
                aircraft_vector[i].Location = new Point(Convert.ToInt32(vuelos[i].GetOrigen_X()), Convert.ToInt32(vuelos[i].GetOrigen_Y()));
                aircraft_vector[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = new Bitmap("avion.png");
                aircraft_vector[i].Image = (Image)image;
                panel1.Controls.Add(aircraft_vector[i]);
            }
        }

        private void CargarAviones()
        {
            
            foreach (CAvion avion in vuelos)
            {
                PictureBox aircraft = new PictureBox();
                aircraft.ClientSize = new Size(20, 20);
                aircraft.Location = new Point(Convert.ToInt32(avion.GetOrigen_X()), Convert.ToInt32(avion.GetOrigen_Y()));
                aircraft.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = new Bitmap("avion.png");
                aircraft.Image = (Image)image;
                panel1.Controls.Add(aircraft);
            }
        }


        private void CargarFichero_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                int p = lista.CargarVuelos(filename, this.lista);

                if (p == -1)
                {
                    MessageBox.Show("Fichero no se ha encontrado");
                }

                else if (p == -2)
                {
                    MessageBox.Show("Formato inesperado");
                }

                else
                {
                    MessageBox.Show("Fichero Cargado");
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
