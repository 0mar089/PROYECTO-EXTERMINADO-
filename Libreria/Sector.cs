using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sector;
using ListaDeVuelos;
using Avion;
using System.Drawing;
namespace Sector
{
    public class CSector
    {
        string identificador_sector;
        int capacidad_max;
        List<Point> Vertices = new List<Point>();

        // Setters

        public void SetPoint(Point p)
        {
            this.Vertices.Add(p);
        }
        public void Set_ID(string ID_recibida)
        {
            this.identificador_sector = ID_recibida;
        }
        public void Set_Capmax(int Capmax_recibida)
        {
            this.capacidad_max = Capmax_recibida;
        }


        // Getters

        public List<Point> GetList()
        {
            return this.Vertices;
        }
        public string Get_ID()
        {
            return this.identificador_sector;
        }
        public int Get_Capmax()
        {
            return this.capacidad_max;
        }

        // FUNCIÓN QUE CARGA LA LISTA DE DATOS DEL SECTOR DEL FICHERO
        public int CargarSector(string nombre_fichero)
        {
            try
            {
                StreamReader fichero = new StreamReader(nombre_fichero);
                string linea = fichero.ReadLine();
                while (linea != null)
                {
                    string[] trozos = linea.Split(" , ");
                    this.Set_ID(trozos[0]);
                    this.Set_Capmax(Convert.ToInt32(trozos[1]));

                    

                    for(int i = 3; i<trozos.Length; i+=2)
                    {
                        Point p = new Point();

                        p.X = Convert.ToInt32(trozos[i - 1]);
                        p.Y = Convert.ToInt32(trozos[i]);

                        this.Vertices.Add(p);
                    }

                    linea = fichero.ReadLine();
                }
                fichero.Close();
                return 0;
            }
            catch (FileNotFoundException)
            {
                return -1;
            }
            catch (FormatException)
            {
                return -2;
            }

        }



        // FUNCION QUE TE CALCULA SI LA POSICION DEL AVION ESTA DENTRO DEL POLIGONO Y TE DEVUELVE EL PORCENTAJE
        public double EstaDentro(CListaDeVuelos lista)
        {
            int i, j, k = 0;
            bool c = false;
            double contador = 0;
            CAvion[] vuelos = lista.GetLista();
            for (i = 0, j = this.Vertices.Count - 1; i < this.Vertices.Count; j = i++)
            {
                if (((this.Vertices[i].Y > vuelos[k].GetPosition_Y()) != (this.Vertices[j].Y > vuelos[k].GetPosition_Y())) &&
                 (vuelos[k].GetPosition_X() < (this.Vertices[j].X - this.Vertices[i].X) * (vuelos[k].GetPosition_Y() - this.Vertices[i].Y) / (this.Vertices[j].Y - this.Vertices[i].Y) + this.Vertices[i].X))
                {
                    c = true;
                }
                if(c == true)
                {
                    contador++;
                }
                    
            }
            return (contador * 100 / lista.GetNum());
        }



        // FUNCIÓN QUE IMPRIME LA INFORMACIÓN DEL SECTOR
        public void Imprimir_Menú_Sector()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" El ID es {0}", this.Get_ID());
            Console.WriteLine(" La capacidad máxima es es {0}", this.Get_Capmax());
            Console.WriteLine(" La posición del sector (referencia pos esquina superior derecha) es {0}, {1} ", this.Get_Posrec_x(), this.Get_Posrec_y());
            Console.WriteLine(" Las dimensiones del sector {0}, {1}", this.Get_Anchorec(), this.Get_Altorec());
            Console.WriteLine("----------------------------------------------");
        }
    }
}