using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sector;
using ListaDeVuelos;
using Avion;

namespace Sector
{
    public class CSector
    {
        string identificador_sector;
        int capacidad_max;
        double posicion_rectangulo_x, posicion_rectangulo_y, ancho_rectangulo, alto_rectangulo;


        // Setters

        public void Set_ID(string ID_recibida)
        {
            this.identificador_sector = ID_recibida;
        }

        public void Set_Capmax(int Capmax_recibida)
        {
            this.capacidad_max = Capmax_recibida;
        }

        public void Set_Posrec_x(double posrecx_recibida)
        {
            this.posicion_rectangulo_x = posrecx_recibida;
        }

        public void Set_Posrec_y(double posrecy_recibida)
        {
            this.posicion_rectangulo_y = posrecy_recibida;
        }

        public void Set_Anchorec(double achorec_recibido)
        {
            this.ancho_rectangulo = achorec_recibido;
        }

        public void Set_Altorec(double altorec_recibido)
        {
            this.alto_rectangulo = altorec_recibido;
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

        public double Get_Posrec_x()
        {
            return this.posicion_rectangulo_x;
        }

        public double Get_Posrec_y()
        {
            return this.posicion_rectangulo_y;
        }

        public double Get_Anchorec()
        {
            return this.ancho_rectangulo;
        }

        public double Get_Altorec()
        {
            return this.alto_rectangulo;
        }

        // FUNCIÓN QUE CARGA LA LISTA DE DATOS DEL SECTOR DEL FICHERO

        public int CargarSectorAlConstructor(string nombre_fichero)
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
                    this.Set_Posrec_x(Convert.ToDouble(trozos[2]));
                    this.Set_Posrec_y(Convert.ToDouble(trozos[3]));
                    this.Set_Anchorec(Convert.ToDouble(trozos[4]));
                    this.Set_Altorec(Convert.ToDouble(trozos[5]));

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


        // FUNCIÓN QUE CALCULA EL PORCENTAJE DE AVIONES EN EL SECTOR
        public double CalculoSector(CListaDeVuelos lista, CSector sector)
        {
            double porcentaje;
            double contador = 0;
            CAvion[] vuelos = lista.GetLista();
            for (int i = 0; i < lista.GetLista().Length; i++)
            {
                if ((sector.Get_Posrec_x() < vuelos[i].GetPosition_X() && vuelos[i].GetPosition_X() < sector.Get_Posrec_x() + sector.Get_Anchorec()) && (sector.Get_Posrec_y() < vuelos[i].GetPosition_Y() && vuelos[i].GetPosition_Y() < sector.Get_Posrec_y() + sector.Get_Anchorec()))
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
            Console.WriteLine(" La posición del sector (referencia pos esquina superior derecha) es {0}, {1} ", this.Get_Posrec_x(), this.Get_Posrec_y());
            Console.WriteLine(" Las dimensiones del sector {0}, {1}", this.Get_Anchorec(), this.Get_Altorec());
            Console.WriteLine("----------------------------------------------");

        }




    }



}
