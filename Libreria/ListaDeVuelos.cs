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
        public CAvion[] vuelos;

        public CListaDeVuelos()
        {
            this.vuelos = new CAvion[MAX_AVIONES];
        }

        // CARGAR 
        public int CargarVuelos(string nombre_fichero, CListaDeVuelos vuelos)
        {
            try
            {
                StreamReader fichero = new StreamReader(nombre_fichero);
                string linea = fichero.ReadLine();
                int i = 0;
                while (linea != null && !string.IsNullOrWhiteSpace(linea))
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


                    CAvion avion = new CAvion(identificador, compañía, origen_x, origen_y, destino_x, destino_y, velocidad, posición_x, posición_y);

                    vuelos.vuelos[i] = avion;

                    linea = fichero.ReadLine();
                    i++;

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

        // Función para simular

        public void Calculo(CListaDeVuelos lista, double tiempo)
        {
            int i;

            for (i = 0; i < lista.vuelos.Length; i++)
            {

                double cateto_opuesto = Math.Abs(((lista.vuelos[i].GetDestino_Y()) - (lista.vuelos[i].GetOrigen_Y())));
                double cateto_contiguo = Math.Abs(((lista.vuelos[i].GetDestino_X()) - (lista.vuelos[i].GetOrigen_X())));
                double hipotenusa = Math.Sqrt(Math.Pow(lista.vuelos[i].GetDestino_X() - lista.vuelos[i].GetOrigen_X(), 2) + Math.Pow(lista.vuelos[i].GetDestino_Y() - lista.vuelos[i].GetOrigen_Y(), 2));

                double coseno = cateto_contiguo / hipotenusa;
                double seno = cateto_opuesto / hipotenusa;

                double Avance_x = (lista.vuelos[i].GetSpeed() / 60) * tiempo * coseno;
                double Avance_y = (lista.vuelos[i].GetSpeed() / 60) * tiempo * seno;

                double nueva_posicion_x = Avance_x + lista.vuelos[i].GetOrigen_X();
                double nueva_posicion_y = -Avance_y + lista.vuelos[i].GetOrigen_Y();


                lista.vuelos[i].SetPosition_X(nueva_posicion_x);
                lista.vuelos[i].SetPosition_Y(nueva_posicion_y);

            }
        }





        public void Imprimir_Menú_Aviones(CListaDeVuelos lista)
        {
            int i;
            for (i = 0; i < MAX_AVIONES; i++)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" El ID es {0}", lista.vuelos[i].GetID());
                Console.WriteLine(" La compañía es {0}", lista.vuelos[i].GetComp());
                Console.WriteLine(" El origen es ({0}, {1}) ", lista.vuelos[i].GetOrigen_X(), lista.vuelos[i].GetOrigen_Y());
                Console.WriteLine(" El destino ({0}, {1})", lista.vuelos[i].GetDestino_X(), lista.vuelos[i].GetDestino_Y());
                Console.WriteLine(" La velocidad {0}", lista.vuelos[i].GetSpeed());
                Console.WriteLine(" La posición del avión es ({0}, {1})", lista.vuelos[i].GetPosition_X(), lista.vuelos[i].GetPosition_Y());
                Console.WriteLine("----------------------------------------------");
            }

        }

    }
}
