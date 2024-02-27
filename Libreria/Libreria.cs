using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class CAvion //ATRIBUTOS
    {
        string identificador; //string 
        string compañía; //string
        double origen_x; //dos R
        double origen_y; //dos R
        double destino_x; //dos R
        double destino_y; //dos R
        double velocidad; // nudos x segundo
        double posición_x; //dos R
        double posición_y; //dos R

        public CAvion(string id, double ox, double oy, double dx, double dy, double velocidad, double px, double py) // atributos en orden
        {
            this.identificador = id;
            this.origen_x = ox;
            this.origen_y = oy;
            this.destino_x = dx;
            this.destino_y = dy; 
            this.velocidad = velocidad;
            this.px = px;
            this.py = py;
        }

    }
}




/*
 
 1. Ordenar/Crear atributos, Crear Setters y Getters
 2. Cargar y Guardar archivo probandolo y testeandolo con un.txt de verdad
 3. Funciones Sector / Cambio de posicion avion
 4. Testear bugs/ gestion de posibles errores
 
 */
