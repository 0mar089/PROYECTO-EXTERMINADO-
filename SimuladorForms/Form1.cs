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
        PictureBox[] aircraft_vector = new PictureBox[5];
        const int MAX = 1000;
        CListaDeVuelos lista = new CListaDeVuelos();
        CSector Sector = new CSector();
        CAvion[] vuelos;
        int tag;


        public Form1()
        {
            InitializeComponent();
            //ResetListaAviones();

            vuelos = lista.GetLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }


        public void CargarAviones()
        {

            for (int i = 0; i < 5; i++)
            {
                PictureBox aircraft = new PictureBox();
                aircraft.ClientSize = new Size(20, 20);
                aircraft.Location = new Point(Convert.ToInt32(vuelos[i].GetOrigen_X()), Convert.ToInt32(vuelos[i].GetOrigen_Y()));
                aircraft.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = new Bitmap("avion.png");
                aircraft.Width = 50;
                aircraft.Height = 50;
                aircraft.Image = (Image)image;
                panel1.Controls.Add(aircraft);
                aircraft_vector[i] = aircraft;
                aircraft.Tag = i;
                aircraft.Click += new System.EventHandler(this.aircraft_Click);
            }
        }




        private void aircraft_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            this.tag = i;
            Form2 f2 = new Form2();
            f2.SetVuelos(this.vuelos);
            f2.SetTag(i);
            f2.ShowDialog();

        }

        private void CargarFichero_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                int p = lista.CargarVuelos(filename, this.lista);
                this.vuelos = lista.GetLista();

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
                    CargarAviones();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                MessageBox.Show(filename);
                int err = lista.GuardarFichero(filename);
                if (err == 0)
                {
                    MessageBox.Show("Fichero Guardado");
                }
                else if (err == -2)
                {
                    MessageBox.Show("Formato inesperado");
                }
                else
                {
                    MessageBox.Show("Fichero no encontrado");
                }
            }
        }

        private void cargarSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                int p = Sector.CargarSector(filename);

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
                    panel1.Invalidate();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            //Colour to draw the rectangle
            Pen myPen = new Pen(Color.Green);
            // Points that define the rectangle
            Point[] polygonPoints = new Point[4];
            polygonPoints[0] = new Point(Convert.ToInt32(Sector.Get_Posrec_x()), Convert.ToInt32(Sector.Get_Posrec_y()));
            polygonPoints[1] = new Point(Convert.ToInt32(Sector.Get_Posrec_x()), Convert.ToInt32(Sector.Get_Posrec_y()) + Convert.ToInt32(Sector.Get_Altorec()));
            polygonPoints[2] = new Point(Convert.ToInt32(Sector.Get_Posrec_x()) + Convert.ToInt32(Sector.Get_Anchorec()), Convert.ToInt32(Sector.Get_Posrec_y()) + Convert.ToInt32(Sector.Get_Altorec()));
            polygonPoints[3] = new Point(Convert.ToInt32(Sector.Get_Posrec_x()) + Convert.ToInt32(Sector.Get_Anchorec()), Convert.ToInt32(Sector.Get_Posrec_y()));
            //Draw the rectangle
            graphics.DrawPolygon(myPen, polygonPoints);
            myPen.Dispose();
        }


        public CAvion[] Get_Vector()
        {
            return this.vuelos;
        }

        public int Get_Tag()
        {
            return this.tag;
        }

        private void listarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.SetLista(this.lista);
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tiempo = Convert.ToDouble(textBox1.Text);
            lista.Calculo(lista, tiempo);
            timer1.Interval = 500;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 5; i++)
            {
                aircraft_vector[i].Location = new Point(Convert.ToInt32(vuelos[i].GetPosition_X()), Convert.ToInt32(vuelos[i].GetPosition_Y()));
                
            }
            double tiempo = Convert.ToDouble(textBox1.Text);
            lista.Calculo(lista, tiempo);
        }
    }
}
