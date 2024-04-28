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
    public partial class PropiedadesAviones : Form
    {

        CListaDeVuelos lista;

        public PropiedadesAviones()
        {
            InitializeComponent();
            
        }


        public void SetLista(CListaDeVuelos lista)
        {
            this.lista = lista;
            

        }
     
        // FUNCION PARA VER LOS DATOS DE TODOS LOS AVIONES EN UN DATA GRID
        private void Form3_Load(object sender, EventArgs e)
        {
            matriz.ColumnCount = 9;
            matriz.RowCount = 5;
            matriz.ColumnHeadersVisible = false;
            matriz.RowHeadersVisible = false;
            matriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            matriz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            matriz.ReadOnly = true;
            CAvion[] vuelos = lista.GetLista();
            foreach (DataGridViewColumn column in matriz.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }


            matriz.Rows[0].Cells[0].Value = "Identificador";
            matriz.Rows[0].Cells[1].Value = "Compañía";
            matriz.Rows[0].Cells[2].Value = "Origen X";
            matriz.Rows[0].Cells[3].Value = "Origen Y";
            matriz.Rows[0].Cells[4].Value = "Destino X";
            matriz.Rows[0].Cells[5].Value = "Destino Y";
            matriz.Rows[0].Cells[6].Value = "Velocidad";
            matriz.Rows[0].Cells[7].Value = "Posición X";
            matriz.Rows[0].Cells[8].Value = "Posición Y";

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Arial", 12, FontStyle.Bold);
            style.ForeColor = Color.Black; // Cambiar el color del texto si es necesario
            matriz.Rows[0].DefaultCellStyle = style;

            foreach (DataGridViewColumn column in matriz.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            // J = COLUMNAS, I = FILAS

            for (int j = 0; j < 9; j++)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (j == 0)
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
     
