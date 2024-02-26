using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class CAvion //ATRIBUTOS
    {
        string identificador;
        double posición_origen_x;
        double posición_origen_y;
        double destino_x;
        double destino_y;
        double velocidad;
        double posición_x;
        double posición_y;
        
        public CAvion(string id, double ox, double oy, double dx, double dy, double velocidad, double px, double py) // atributos en orden
        {
            this.identificador = id;
            this.posición_origen_x = ox;
            this.posición_origen_y = oy;
            this.destino_x = dx;
            this.destino_y = dy;
            this.velocidad = velocidad;
            this.px = px;
            this.py = py;
        }

    }
}
