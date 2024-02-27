using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace ListaDeVuelos
{
    public class ListaDeVuelos
    {
        const int MAX_AVIONES = 5;
        ListaDeVuelos[] vuelos;

        public ListaDeVuelos()
        {
            this.vuelos = new ListaDeVuelos[MAX_AVIONES];
        }

        // CARGAR 

        public int CargarVuelos(string nombre_fichero)
        {
            try
            {
                StreamReader fichero = new StreamReader(nombre_fichero);
                string linea = fichero.ReadLine();

                while (linea != null)
                {
                    string[] trozos = linea.Split(" , ");
                    
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
