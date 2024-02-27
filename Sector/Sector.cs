using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avion;

namespace Sector
{
    public class Sector
    {
        string identificador_sector;
        int capacidad_max;
        double posicion_rectangulo_x, posicion_rectangulo_y, ancho_rectangulo, alto_rectangulo;

        // Constructor del Sector

        Sector(string ID_local, int capacity_local, double posicion_rectangulo_x_local, double posicion_rectangulo_y_local, double ancho_local, double alto_local)
        {
            this.identificador_sector = ID_local;
            this.capacidad_max = capacity_local;
            this.posicion_rectangulo_x = posicion_rectangulo_x_local;
            this.posicion_rectangulo_y = posicion_rectangulo_y_local;
            this.ancho_rectangulo = ancho_local;
            this.alto_rectangulo = alto_local;
        }

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

        // Cargar y Guardar

        public int CargarSectorAlConstructor(string nombre_fichero)
        {
            try
            {
                StreamReader fichero = new StreamReader(nombre_fichero);
                string linea = fichero.ReadLine();
                int contador = 0;

                while (linea != null)
                {
                    string[] trozos = linea.Split(" , ");

                    Set_ID(trozos[1]);
                    Set_Capmax(Convert.ToInt32(trozos[2]));
                    Set_Posrec_x(Convert.ToDouble(trozos[3]));  
                    Set_Posrec_y(Convert.ToDouble(trozos[4]));
                    Set_Anchorec(Convert.ToDouble(trozos[5]));
                    Set_Altorec(Convert.ToDouble(trozos[6]));

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

    }
}
