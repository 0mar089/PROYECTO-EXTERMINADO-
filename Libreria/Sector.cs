using System;
using System.Collections.Generic;
using System.Collections;
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
        List<Point> Puntos = new List<Point>();


        // Setters

        public void Set_ID(string ID_recibida)
        {
            this.identificador_sector = ID_recibida;
        }

        public void Set_Capmax(int Capmax_recibida)
        {
            this.capacidad_max = Capmax_recibida;
        }

        public void Set_Punto(Point punto)
        {
            this.Puntos.Add(punto);
        }

        // Getters

        public string Get_ID()
        {
            return this.identificador_sector;
        }

        public int Get_Capmax()
        {
            return this.capacidad_max;
        }

        public int Get_x(int i)
        {
            return this.Puntos[i].X;
        }

        public int Get_y(int i)
        {
            return this.Puntos[i].Y;
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
                    int x = 0;
                    int y = 0;
                    this.Set_ID(trozos[0]);
                    this.Set_Capmax(Convert.ToInt32(trozos[1]));
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
                            this.Puntos.Add(p);
                            x = 0;
                            y = 0; 
                        }
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
            catch (IndexOutOfRangeException)
            {
                return -3;
            }

        }
        public static bool IsPlaneInSector(Point point, List<Point> polygon)
        {
            int count = 0;
            int polygonSize = polygon.Count;
            Point lastPoint = polygon[polygonSize - 1];
            for (int i = 0; i < polygonSize; i++)
            {
                Point currentPoint = polygon[i];
                if (currentPoint.Y <= point.Y)
                {
                    if (currentPoint.X > point.X && lastPoint.X <= point.X)
                    {
                        if (point.Y >= (lastPoint.Y - (point.X - lastPoint.X) * (currentPoint.Y - lastPoint.Y) / (currentPoint.X - lastPoint.X)))
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    if (currentPoint.X <= point.X && lastPoint.X > point.X)
                    {
                        if (point.Y < (lastPoint.Y - (point.X - lastPoint.X) * (currentPoint.Y - lastPoint.Y) / (currentPoint.X - lastPoint.X)))
                        {
                            count++;
                        }
                    }
                }
                lastPoint = currentPoint;
            }
            return count % 2 == 1;
        }


        // FUNCIÓN QUE CALCULA EL PORCENTAJE DE AVIONES EN EL SECTOR
        public double CalculoSector(CListaDeVuelos lista, CSector sector)
        {
 
            double porcentaje;
            double contador = 0;
            CAvion[] vuelos = lista.GetLista();
            for (int i = 0; i < lista.GetLista().Length; i++)
            {
                int x = Convert.ToInt32(vuelos[i].GetPosition_X());
                int y = Convert.ToInt32(vuelos[i].GetPosition_X());
                Point p = new Point(x, y);
                if (IsPlaneInSector(p, this.Puntos)==true) 
                {
                    contador++;
                }


            }
            porcentaje = (contador / sector.Get_Capmax()) * 100;
            return porcentaje;
           
        }
    

        // FUNCIÓN QUE IMPRIME LA INFORMACIÓN DEL SECTOR
        public void Imprimir_Menú_Sector()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" El ID es {0}", this.Get_ID());
            Console.WriteLine(" La capacidad máxima es es {0}", this.Get_Capmax());
            Console.WriteLine(" La posición del sector (referencia pos esquina superior derecha) es {0}, {1} ");
            Console.WriteLine(" Las dimensiones del sector {0}, {1}");
            Console.WriteLine("----------------------------------------------");

        }




    }




}
