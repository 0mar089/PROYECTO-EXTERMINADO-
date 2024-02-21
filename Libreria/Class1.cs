using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Avion
    {
        string ID;
        double ox;
        double oy;
        double dx;
        double dy;
        double velocidad;
        double px;
        double py;
        public Avion(string id, double ox, double oy, double dx, double dy, double velocidad, double px, double py)
        {
            this.ID = id;
            this.ox = ox;
            this.oy = oy;
            this.dx = dx;
            this.dy = dy;
            this.velocidad = velocidad;
            this.px = px;
            this.py = py;
        }

        


    }
}
