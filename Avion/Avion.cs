using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avion
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

        public CAvion(string id, string comp, double ox, double oy, double dx, double dy, double velocidad, double px, double py) // atributos en orden
        {
            this.identificador = id;
            this.compañía = comp;
            this.origen_x = ox;
            this.origen_y = oy;
            this.destino_x = dx;
            this.destino_y = dy;
            this.velocidad = velocidad;
            this.posición_x = px;
            this.posición_y = py;
        }

        // SETTERS
        public void SetID(string identificador)
        {
            this.identificador = identificador;
        }

        public void SetComp(string compañia)
        {
            this.compañía = compañia;
        }

        public void SetOrigen_X(double origen_x)
        {
            this.origen_x = origen_x;
        }

        public void SetOrigen_Y(double origen_y)
        {
            this.origen_y = origen_y;
        }

        public void SetDestino_X(double destino_x)
        {
            this.destino_x = destino_x;
        }

        public void SetDestino_Y(double destino_y)
        {
            this.destino_y = destino_y;
        }

        public void SetSpeed(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public void SetPosition_X(double posicion_x)
        {
            this.posición_x = posicion_x;
        }

        public void SetPosition_Y(double posicion_y)
        {
            this.posición_y = posicion_y;
        }

        // GETTERS

        public string GetID()
        {
            return this.identificador;
        }

        public string GetComp()
        {
            return this.compañía;
        }

        public double GetOrigen_X()
        {
            return this.origen_x;
        }

        public double GetOrigen_Y()
        {
            return this.origen_y;
        }

        public double GetDestino_X()
        {
            return this.destino_x;
        }

        public double GetDestino_Y()
        {
            return this.destino_y;
        }

        public double GetSpeed()
        {
            return this.velocidad;
        }

        public double GetPosition_X()
        {
            return this.posición_x;
        }

        public double GetPosition_Y()
        {
            return this.posición_y;
        }

    }
}
