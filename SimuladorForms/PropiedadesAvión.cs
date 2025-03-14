﻿using Avion;
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
    public partial class PropiedadesAvión : Form
    {
        CAvion[] vuelos;
        int tag;
        FormularioPrincipal f1 = new FormularioPrincipal();

        public PropiedadesAvión()
        {
            InitializeComponent();
        }

        public void SetVuelos(CAvion[] lista_vuelos)
        {
            this.vuelos = lista_vuelos;
        }

        public void SetTag(int i)
        {
            this.tag = i;
        }

        // FUNCION PARA VER LOS DATOS DE 1 AVION
        private void Form2_Load(object sender, EventArgs e)
        {

            int i = f1.Get_Tag();



            label1.Text = Convert.ToString(this.vuelos[tag].GetID());
            label2A.Text = Convert.ToString(this.vuelos[tag].GetComp());
            label3.Text = Convert.ToString(this.vuelos[tag].GetOrigen_X());
            label4.Text = Convert.ToString(this.vuelos[tag].GetOrigen_Y());
            label5A.Text = Convert.ToString(this.vuelos[tag].GetDestino_X());
            label6.Text = Convert.ToString(this.vuelos[tag].GetDestino_Y());
            label7.Text = Convert.ToString(this.vuelos[tag].GetSpeed());
            label8.Text = Convert.ToString(this.vuelos[tag].GetPosition_X());
            label9.Text = Convert.ToString(this.vuelos[tag].GetPosition_Y());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int retraso = Convert.ToInt32(textBox1.Text);
                f1.SetRetraso(retraso, this.tag);
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos introducidos incorrectos");
            }
        }
    }
}
