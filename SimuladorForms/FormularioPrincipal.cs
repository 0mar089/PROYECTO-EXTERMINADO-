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
using System.Runtime.CompilerServices;
using System.Drawing;


namespace SimuladorForms
{
    public partial class FormularioPrincipal : Form
    {
        PictureBox[] aircraft_vector = new PictureBox[5];
        const int MAX = 1000;
        CListaDeVuelos lista = new CListaDeVuelos();
        CSector Sector = new CSector();
        CAvion[] vuelos;
        int tag;
        double tiempo;
        int i;
        int cont = 5;
        bool verificar = false;
        bool verif_cargar = false;
        string filename;
        string filename_s;

        public FormularioPrincipal()
        {
            InitializeComponent();
            //ResetListaAviones();

            vuelos = lista.GetLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // FUNCION PARA CARGAR LAS IMAGENES DE LOS AVIONES
        public void CargarAviones()
        {

            for (int i = 0; i < lista.GetNumVuelos(); i++)
            {
                PictureBox aircraft = new PictureBox();
                aircraft.ClientSize = new Size(20, 20);
                aircraft.Location = new Point(Convert.ToInt32(vuelos[i].GetPosition_X()), Convert.ToInt32(vuelos[i].GetPosition_Y()));
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


        // FUNCION PARA ABRIR FORMULARIO PARA VER LOS DATOS DE 1 AVION
        private void aircraft_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            this.tag = i;
            PropiedadesAvión f2 = new PropiedadesAvión();
            f2.SetVuelos(this.vuelos);
            f2.SetTag(i);
            f2.ShowDialog();

        }

        // FUNCION PARA CARGAR LOS AVIONES
        private void CargarFichero_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filename = openFileDialog1.FileName;

                int p = lista.CargarVuelos(this.filename);
                this.vuelos = lista.GetLista();

                if (p == -1)
                {
                    MessageBox.Show("Fichero no se ha encontrado");
                }

                else if (p == -2)
                {
                    MessageBox.Show("Formato inesperado");
                }
                else if (p == -3)
                {
                    MessageBox.Show("Formato inesperado");
                }
                else
                {
                    MessageBox.Show("Fichero Cargado");
                    this.verif_cargar = true;
                    CargarAviones();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // FUNCION PARA GUARDAR LOS AVIONES
        private void guardarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.verif_cargar == false)
            {
                MessageBox.Show("Carga el fichero primero");
            }
            else
            {
                int err = lista.GuardarFichero(this.filename);
                if (err == 0)
                {
                    MessageBox.Show(filename);
                    MessageBox.Show("Fichero Guardado");
                    this.cont = 5;
                }
                else if (err == -2)
                {
                    MessageBox.Show("Formato inesperado");
                }
                else if (err == -3)
                {
                    MessageBox.Show("Fichero vacio, no se puede guardar");
                }
                else if (err == -4)
                {
                    MessageBox.Show("Fichero vacio, no se puede guardar");
                }
                else
                {
                    MessageBox.Show("Fichero no encontrado");
                }
            }

        }

        // FUNCION PARA CARGAR EL SECTOR
        private void cargarSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename_s = openFileDialog1.FileName;

                int p = Sector.CargarSector(filename_s);

                if (p == -1)
                {
                    MessageBox.Show("Fichero no se ha encontrado");
                }

                else if (p == -2)
                {
                    MessageBox.Show("Formato inesperado");
                }
                else if (p == -3)
                {
                    MessageBox.Show("Formato Inesperado");
                }
                else
                {
                    MessageBox.Show("Fichero Cargado");
                    this.verificar = true;

                    panel1.Invalidate();
                }
            }
        }

        // FUNCION PARA PINTAR EL PANEL DEL SECTOR
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.verificar == true) { 
                List<Point> puntos = new List<Point>();
                try
                {
                    StreamReader fichero = new StreamReader(filename_s);
                    string linea = fichero.ReadLine();

                    while (linea != null)
                    {
                        string[] trozos = linea.Split(" , ");
                        int x = 0;
                        int y = 0;
                        for (int i = 2; i < trozos.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                x = Convert.ToInt32(trozos[i]);
                            }
                            else
                            {
                                y = Convert.ToInt32(trozos[i]);
                                Point p = new Point(x, y);
                                puntos.Add(p);
                                x = 0;
                                y = 0;
                            }
                        }

                        linea = fichero.ReadLine();
                    }

                    fichero.Close();

                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Falta el fichero");
                }
                Point[] poligono = new Point[puntos.Count()];
                for (int i = 0; i < poligono.Length; i++)
                {
                    poligono[i] = puntos[i];
                }
                System.Drawing.Graphics graphics = e.Graphics;
                if (Sector.CalculoSector(this.lista, this.Sector) > 33.33 && Sector.CalculoSector(this.lista, this.Sector) < 66.66)
                {
                    Pen myPen = new Pen(Color.Yellow, 4);
                    graphics.DrawPolygon(myPen, poligono);
                    myPen.Dispose();
                }
                else if (Sector.CalculoSector(this.lista, this.Sector) > 66.66)
                {
                    Pen myPen = new Pen(Color.Red, 4);
                    graphics.DrawPolygon(myPen, poligono);
                    myPen.Dispose();
                }
                else
                {
                    Pen myPen = new Pen(Color.Green, 4);
                    graphics.DrawPolygon(myPen, poligono);
                    myPen.Dispose();
                }
                 
            }

        }


        public CAvion[] Get_Vector()
        {
            return this.vuelos;
        }

        public int Get_Tag()
        {
            return this.tag;
        }

        // FUNCION PARA LISTAR VUELOS
        private void listarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verif_cargar == true)
            {
                PropiedadesAviones f3 = new PropiedadesAviones();
                f3.SetLista(this.lista);
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Carga el fichero primero");
            }
        }

        // FUNCION PARA SIMULAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cont = 5;
                this.tiempo = Convert.ToDouble(textBox1.Text);
                lista.Calculo(this.tiempo / this.cont);
                timer1.Interval = 500;
                timer1.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos introducidos incorrectos");
            }

        }

        public void VerificarAviones()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int w = 0; w < lista.GetNumVuelos(); w++)
            {

                int posicionpicturex = (Convert.ToInt32(vuelos[w].GetPosition_X()));
                int posicionpicturey = (Convert.ToInt32(vuelos[w].GetPosition_Y()));

                aircraft_vector[w].Location = new Point(posicionpicturex, posicionpicturey);

            }

            if (this.cont == 1)
            {
                timer1.Stop();
                VerificarAviones();
            }
            else
            {
                this.cont--;
                lista.Calculo(this.tiempo / this.cont);
            }
            panel1.Invalidate();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // FUNCION DE RESET AVIONES Y SECTOR
        private void button2_Click(object sender, EventArgs e)
        {

            if (this.verif_cargar == true)
            {
                this.cont = 5;
                for (int i = 0; i < lista.GetNumVuelos(); i++)
                {
                    this.vuelos[i].ResetPosition();
                    aircraft_vector[i].Location = new Point(Convert.ToInt32(this.vuelos[i].GetPosition_X()), Convert.ToInt32(this.vuelos[i].GetPosition_Y()));
                    panel1.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("No reinicies si no tienes nada cargado");
            }

        }
    }
}
