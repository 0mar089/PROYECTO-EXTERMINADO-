using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Avion;
namespace ListaDeVuelos
{
    public class CListaDeVuelos
    {
        const int MAX_AVIONES = 100;
        CAvion[] vuelos;
        int numvuelos;

        public CListaDeVuelos()
        {
            this.vuelos = new CAvion[MAX_AVIONES];
        }

        public CAvion[] GetLista()
        {
            return (this.vuelos);
        }

        public int GetNum()
        {
            return (numvuelos);
        }

        // FUNCIÓN PARA CARGAR LA LISTA DE VUELOS DEL FICHERO
        public int CargarVuelos(string nombre_fichero)
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
                    
                    this.vuelos[i] = avion;

                    linea = fichero.ReadLine();
                    i++;
                    numvuelos++;
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
            catch (IndexOutOfRangeException)
            {
                return -3;
            }

        }


        public  int GuardarFichero(string path)
        {
            try
            {
                for (int i = 0; i < this.numvuelos; i++)
                {
                    this.vuelos[i].SetOrigen_X(this.vuelos[i].GetPosition_X());
                    this.vuelos[i].SetOrigen_Y(this.vuelos[i].GetPosition_Y());
                }
                StreamWriter fichero = new StreamWriter(path);
                for (int i = 0; i < MAX_AVIONES; i++)
                {
                    fichero.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8}", this.vuelos[i].GetID(), this.vuelos[i].GetComp(), this.vuelos[i].GetOrigen_X(), this.vuelos[i].GetOrigen_Y(), this.vuelos[i].GetDestino_X(), this.vuelos[i].GetDestino_Y(), this.vuelos[i].GetSpeed(), this.vuelos[i].GetPosition_X(), this.vuelos[i].GetPosition_Y());
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
            catch (ArgumentException)
            {
                return -3;
            }
            catch (NullReferenceException)
            {
                return -4;
            }
        }

        // FUNCIÓN QUE CALCULA LA SIMULACION DE LOS AVIONES EN UN TIEMPO

        public void Calculo(double tiempo)
        {
            for (int i = 0; i < this.numvuelos; i++)
            {

                double cateto_opuesto = Math.Abs(((this.vuelos[i].GetDestino_Y()) - (this.vuelos[i].GetOrigen_Y())));
                double cateto_contiguo = Math.Abs(((this.vuelos[i].GetDestino_X()) - (this.vuelos[i].GetOrigen_X())));
                double hipotenusa = Math.Sqrt(Math.Pow(this.vuelos[i].GetDestino_X() - this.vuelos[i].GetOrigen_X(), 2) + Math.Pow(this.vuelos[i].GetDestino_Y() - this.vuelos[i].GetOrigen_Y(), 2));

                double coseno = cateto_contiguo / hipotenusa;
                double seno = cateto_opuesto / hipotenusa;
                
                double Avance_x = (this.vuelos[i].GetSpeed()) * (tiempo/60) * coseno;
                double Avance_y = (this.vuelos[i].GetSpeed()) * (tiempo/60) * seno;

                double nueva_posicion_x = Avance_x + this.vuelos[i].GetPosition_X();
                double nueva_posicion_y = -Avance_y + this.vuelos[i].GetPosition_Y();


                this.vuelos[i].SetPosition_X(nueva_posicion_x);
                this.vuelos[i].SetPosition_Y(nueva_posicion_y);

            }
        }

        // FUNCIÓN QUE IMPRIME LA INFORMACIÓN DE LOS AVIONES
        public void Imprimir_Menú_Aviones()
        {
            int i;
            for (i = 0; i < MAX_AVIONES; i++)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" El ID es {0}", this.vuelos[i].GetID());
                Console.WriteLine(" La compañía es {0}", this.vuelos[i].GetComp());
                Console.WriteLine(" El origen es ({0}, {1}) ", this.vuelos[i].GetOrigen_X(), this.vuelos[i].GetOrigen_Y());
                Console.WriteLine(" El destino ({0}, {1})", this.vuelos[i].GetDestino_X(), this.vuelos[i].GetDestino_Y());
                Console.WriteLine(" La velocidad {0}", this.vuelos[i].GetSpeed());
                Console.WriteLine(" La posición del avión es ({0}, {1})", this.vuelos[i].GetPosition_X(), this.vuelos[i].GetPosition_Y());
                Console.WriteLine("----------------------------------------------");
            }

        }

    }
}
