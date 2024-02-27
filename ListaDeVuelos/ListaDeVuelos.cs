using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avion;

namespace ListaDeVuelos
{
    public class CListaDeVuelos
    {
        const int MAX_AVIONES = 5;
        CListaDeVuelos[] vuelos;

        public CListaDeVuelos()
        {
            this.vuelos = new CListaDeVuelos[MAX_AVIONES];
        }

        // CARGAR 
        public int CargarVuelos(string nombre_fichero, CListaDeVuelos vuelos)
        {
            try
            {
                StreamReader fichero = new StreamReader(nombre_fichero);
                string linea = fichero.ReadLine();

                while (linea != null)
                {
                    string[] trozos = linea.Split(" - ");
                    string identificador = trozos[0];
                    string compañía = trozos[1];
                    double origen_x = Convert.ToDouble(trozos[2]);
                    double origen_y = Convert.ToDouble(trozos[3]);
                    double destino_x = Convert.ToDouble(trozos[4]);
                    double destino_y = Convert.ToDouble(trozos[5]);
                    double velocidad = Convert.ToDouble(trozos[6]);
                    double posición_x = Convert.ToDouble(trozos[7]);
                    double posición_y = Convert.ToDouble(trozos[8]);



                }
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
