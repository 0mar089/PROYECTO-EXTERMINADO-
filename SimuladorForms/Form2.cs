using Avion;
using ListaDeVuelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorForms
{
    public partial class Form2 : Form
    {
        CAvion[] vuelos;
        int tag;

        public Form2()
        {
            InitializeComponent();
        }

        public void SetVuelos(CAvion[] vuelos)
        {
            this.vuelos = vuelos;
        }

        public void SetTag(int i)
        {
            this.tag = i;
        }

        // FUNCION PARA VER LOS DATOS DE 1 AVION
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            int i = f1.Get_Tag();



            label1.Text = Convert.ToString(this.vuelos[tag].GetID());
            label2.Text = Convert.ToString(this.vuelos[tag].GetComp());
            label3.Text = Convert.ToString(this.vuelos[tag].GetOrigen_X());
            label4.Text = Convert.ToString(this.vuelos[tag].GetOrigen_Y());
            label5.Text = Convert.ToString(this.vuelos[tag].GetDestino_X());
            label6.Text = Convert.ToString(this.vuelos[tag].GetDestino_Y());
            label7.Text = Convert.ToString(this.vuelos[tag].GetSpeed());
            label8.Text = Convert.ToString(this.vuelos[tag].GetPosition_X());
            label9.Text = Convert.ToString(this.vuelos[tag].GetPosition_Y());
        }
    }
}
