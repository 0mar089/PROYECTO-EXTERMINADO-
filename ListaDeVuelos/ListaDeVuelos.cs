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

    }
}
