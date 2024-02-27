using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Sector
{
    public class Sector
    {
        string identificador_sector;
        int capacidad_max;
        double posicion_rectangulo_x, posicion_rectangulo_y, ancho_rectangulo, alto_rectangulo;

        //constructor del Sector

        public Sector(string ID_local, int capacity_local, double posicion_rectangulo_x_local, double posicion_rectangulo_y_local, double ancho_local, double alto_local)
        {
            this.identificador_sector = ID_local;
            this.capacidad_max = capacity_local;
            this.posicion_rectangulo_x = posicion_rectangulo_x_local;
            this.posicion_rectangulo_y = posicion_rectangulo_y_local;
            this.ancho_rectangulo = ancho_local;
            this.alto_rectangulo = alto_local;
        }


        // Cargar y Guardar

        public int cargar_sector(nombre_fichero)
        {

            StreamReader fichero = new StreamReader(nombre_fichero);
            string línea = fichero.ReadLine();

            try
            {

                for (int contador = 0; línea != null; contador++)
                {



                    string[] trozos = línea.Split(línea',');




                }


            }

            catch
            { 
            
            
            
            
            
            
            }

        
        
        
        
        
        }





    }

}
