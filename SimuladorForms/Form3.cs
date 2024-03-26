using Avion;
using ListaDeVuelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorForms
{
    public partial class Form3 : Form
    {

        CListaDeVuelos lista;

        public Form3()
        {
            InitializeComponent();
            
        }


        public void SetLista(CListaDeVuelos lista)
        {
            this.lista = lista;
            

        }



        private void Form3_Load(object sender, EventArgs e)
        {
            matriz.ColumnCount = 9;
            matriz.RowCount = 5;
            matriz.ColumnHeadersVisible = false;
            matriz.RowHeadersVisible = false;
            matriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            CAvion[] vuelos = lista.GetLista();


            // J = COLUMNAS, I = FILAS

            for (int j = 0; j<9; j++)
            {
                for(int i = 0; i<5; i++)
                {
                    if(j == 0)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetID();
                    }
                    else if (j == 1)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetComp();
                    }
                    else if (j == 2)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetOrigen_X();
                    }
                    else if (j == 3)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetOrigen_Y();
                    }
                    else if (j == 4)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetDestino_X();
                    }
                    else if (j == 5)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetDestino_Y();
                    }
                    else if (j == 6)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetSpeed();
                    }
                    else if (j == 7)
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetPosition_X();
                    }
                    else
                    {
                        matriz.Rows[i].Cells[j].Value = vuelos[i].GetPosition_Y();
                    }
                    
                }
            }
        }   
    }
}
     
