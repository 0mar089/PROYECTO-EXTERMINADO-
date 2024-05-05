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
        CAvion[] vuelos = new CAvion[100];
        int tag;
        double tiempo;
        int i;
        int ciclos;
        int verificar;
        bool verif_cargar = false;
        string filename;
        bool manual;
        List<Point> Vertices = new List<Point>();
        int retraso;
        int contador2;
        int avion_escogido;
        bool verif_sector;
        Stack<CAvion[]> Pila = new Stack<CAvion[]>();
        CAvion[] copia_vuelos = new CAvion[100];


        public FormularioPrincipal()
        {
            InitializeComponent();
            //ResetListaAviones();

            this.vuelos = lista.GetLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SetRetraso(int retraso, int tag)
        {
            this.retraso = retraso;
            this.vuelos[tag].SetRetardo(true);
            this.avion_escogido = tag;
        }
        // FUNCION PARA CARGAR LAS IMAGENES DE LOS AVIONES
        public void CargarAviones()
        {

            for (int i = 0; i < lista.GetNum(); i++)
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
                    this.verificar = -1;
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
                    // cuidao
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


        private List<Point> CalcularVertices()
        {

            int x = Convert.ToInt32(Sector.Get_Posrec_x());
            int y = Convert.ToInt32(Sector.Get_Posrec_y());
            int width = Convert.ToInt32(Sector.Get_Anchorec());
            int height = Convert.ToInt32(Sector.Get_Altorec());


            this.Vertices.Add(new Point(x, y));
            this.Vertices.Add(new Point(x, y + height));
            this.Vertices.Add(new Point(x + width, y + height));
            this.Vertices.Add(new Point(x + width, y));

            return this.Vertices;
        }

        // FUNCION PARA CARGAR EL SECTOR
        private void cargarSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filename = openFileDialog1.FileName;

                int p = Sector.CargarSector(this.filename);

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
                    this.verificar = 1;
                    this.verif_sector = true;
                    //this.Vertices.Add(new Point(Convert.ToInt32(Sector.Get_Posrec_x()), Convert.ToInt32(Sector.Get_Posrec_y())));
                    //this.Vertices.Add(new Point(Convert.ToInt32(Sector.Get_Posrec_x()), Convert.ToInt32(Sector.Get_Posrec_y()) + Convert.ToInt32(Sector.Get_Altorec())));
                    //this.Vertices.Add(new Point(Convert.ToInt32(Sector.Get_Posrec_x()) + Convert.ToInt32(Sector.Get_Anchorec()), Convert.ToInt32(Sector.Get_Posrec_y()) + Convert.ToInt32(Sector.Get_Altorec())));
                    //this.Vertices.Add(new Point(Convert.ToInt32(Sector.Get_Posrec_x()) + Convert.ToInt32(Sector.Get_Anchorec()), Convert.ToInt32(Sector.Get_Posrec_y())));
                    this.Vertices = CalcularVertices();
                    panel1.Invalidate();
                }
            }
        }


        // FUNCION PARA PINTAR EL PANEL DEL SECTOR
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.verif_sector == true)
            {
                System.Drawing.Graphics graphics = e.Graphics;
                if (this.verificar == 1)
                {

                    Pen myPen = new Pen(Color.Green, 4);
                    graphics.DrawPolygon(myPen, this.Vertices.ToArray());
                    //myPen.Dispose();
                }
                else if (this.verificar == -1)
                {
                    if (Sector.CalculoSector(this.lista, this.Sector) > 33.33 && Sector.CalculoSector(this.lista, this.Sector) < 66.66)
                    {
                        Pen myPen = new Pen(Color.Yellow, 4);
                        graphics.DrawPolygon(myPen, this.Vertices.ToArray());
                        myPen.Dispose();
                    }
                    else if (Sector.CalculoSector(this.lista, this.Sector) >= 66.66)
                    {
                        Pen myPen = new Pen(Color.Red, 4);
                        graphics.DrawPolygon(myPen, this.Vertices.ToArray());
                        myPen.Dispose();
                    }
                    else
                    {
                        Pen myPen = new Pen(Color.Green, 4);
                        graphics.DrawPolygon(myPen, this.Vertices.ToArray());
                        myPen.Dispose();
                    }
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

        // FUNCION PARA SIMULAR AUTO
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                this.ciclos = Convert.ToInt32(textBox2.Text);
                this.tiempo = Convert.ToDouble(textBox1.Text);
                lista.Calculo(this.tiempo / this.ciclos);
                timer1.Interval = 1000;
                timer1.Enabled = true;
                this.manual = false;
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

            if (this.manual == false)
            {
                this.copia_vuelos = this.vuelos;
                this.Pila.Push(this.copia_vuelos);
                for (int w = 0; w < lista.GetNum(); w++)
                {

                    if (this.vuelos[w].GetRetardo() == false)
                    {
                        int posicionpicturex = (Convert.ToInt32(vuelos[w].GetPosition_X()));
                        int posicionpicturey = (Convert.ToInt32(vuelos[w].GetPosition_Y()));

                        aircraft_vector[w].Location = new Point(posicionpicturex, posicionpicturey);

                    }
                    else
                    {
                        this.contador2 = 1;
                        timer2.Enabled = true;
                        timer2.Interval = this.retraso * 1000;
                    }


                }



                if (this.ciclos == 1)
                {
                    timer1.Stop();
                    VerificarAviones();
                }
                else
                {
                    this.ciclos--;
                    lista.Calculo(this.tiempo / this.ciclos);
                }
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
                for (int i = 0; i < lista.GetNum(); i++)
                {
                    this.vuelos[i].ResetPosition();
                    this.vuelos[i].SetOrigen_X(this.vuelos[i].GetOrigenNo_X());
                    this.vuelos[i].SetOrigen_Y(this.vuelos[i].GetOrigenNo_Y());
                    aircraft_vector[i].Location = new Point(Convert.ToInt32(this.vuelos[i].GetOrigenNo_X()), Convert.ToInt32(this.vuelos[i].GetOrigenNo_Y()));
                    panel1.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("No reinicies si no tienes nada cargado");
            }

        }

        // SIMULACIÓN MANUAL
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                

                this.tiempo = Convert.ToDouble(textBox1.Text);
                lista.Calculo(this.tiempo);
                for (int w = 0; w < lista.GetNum(); w++)
                {

                    int posicionpicturex = (Convert.ToInt32(vuelos[w].GetPosition_X()));
                    int posicionpicturey = (Convert.ToInt32(vuelos[w].GetPosition_Y()));

                    vuelos[w].SetOrigen_X(vuelos[w].GetPosition_X());
                    vuelos[w].SetOrigen_Y(vuelos[w].GetPosition_Y());


                    aircraft_vector[w].Location = new Point(posicionpicturex, posicionpicturey);

                }
                this.Pila.Push(this.vuelos);
                this.manual = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Datos introducidos incorrectos");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.contador2 == 0)
            {
                this.vuelos[this.avion_escogido].SetRetardo(false);
                timer2.Stop();
            }
            this.contador2 = 1;
        }


        // BOTON DE DESHACER
        private void button4_Click(object sender, EventArgs e)
        {
            this.copia_vuelos = this.Pila.Pop();
            for (int w = 0; w < lista.GetNum(); w++)
            {

                int posicionpicturex = (Convert.ToInt32(this.copia_vuelos[w].GetPosition_X()));
                int posicionpicturey = (Convert.ToInt32(this.copia_vuelos[w].GetPosition_Y()));

                vuelos[w].SetOrigen_X(this.copia_vuelos[w].GetPosition_X());
                vuelos[w].SetOrigen_Y(this.copia_vuelos[w].GetPosition_Y());


                aircraft_vector[w].Location = new Point(posicionpicturex, posicionpicturey);

            }
        }
    }
}
