using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sector
{
    public class CSector
    {
        string ID;
        int capacity;
        double px, py, dx, dy; //posiciones de el punto y dimesiones de este

        public CSector(string ID, int capacity, double px, double py, double dx, double dy) 
        {
            this.ID = ID;
            this.capacity = capacity;
            this.px = px;
            this.py = py;
            this.dx = dx;
            this.dy = dy;
        }
    }
}
