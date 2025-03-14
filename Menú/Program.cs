﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDeVuelos;
using Avion;
using Sector;
using System.Numerics;
namespace Menú
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            CListaDeVuelos vuelos = new CListaDeVuelos();
            CSector sector = new CSector();

            int res = sector.CargarSector("sector.txt");
            int e = vuelos.CargarVuelos("aviones.txt", vuelos);

            if (e != 0 || res != 0)
            {
                if (res == -1)
                {
                    Console.WriteLine("Fichero del sector no encontrado, asegúrese de tenrerlo en /bin/debug y que se llame sector :)");

                }
                else if (res == -2)
                {
                    Console.WriteLine("Formato del sector no esperado");
                }

                if (e == -1)
                {
                    Console.WriteLine("Fichero de la lista de vuelos no encontrado, asegúrese de tenrerlo en /bin/debug y que se llame aviones :)");
                }
                else if (e == -2)
                {
                    Console.WriteLine("Formato de la lista de vuelos no esperado");
                }
            }

            else
            {
                Console.WriteLine("Escoje una opción:");
                Console.WriteLine("1 - Mostrar vuelos");
                Console.WriteLine("2 - Mostrar sector");
                Console.WriteLine("3 - Mostrar ocupación");
                Console.WriteLine("4 - Simulación");
                Console.WriteLine("5 - Guardar y Salir");
                string i = Console.ReadLine();
                while (i != "5")
                {

                    switch (i)
                    {
                        case "1":

                            vuelos.Imprimir_Menú_Aviones(vuelos);
                            break;
                        case "2":

                            sector.Imprimir_Menú_Sector();
                            break;
                        case "3":
                            double porcentaje = sector.CalculoSector(vuelos, sector);
                            if (porcentaje > 100)
                            {
                                Console.WriteLine("Hay una sobrecarga en el Sector");
                            }
                            Console.WriteLine("El porcentaje de aviones en el sector es: {0}% ", porcentaje);
                            Console.WriteLine();
                            break;
                        case "4":


                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Escribe el tiempo de la simulación: ");
                                    double tiempo = Convert.ToDouble(Console.ReadLine());
                                    vuelos.Calculo(vuelos, tiempo);
                                    vuelos.Imprimir_Menú_Aviones(vuelos);
                                    break;
                                }
                                catch (FormatException)
                                {
                                    continue;
                                }
                            }


                            break;
                        default:
                            Console.WriteLine("Error en el codigo");
                            break;
                    }
                    Console.WriteLine("Escoje una opción:");
                    Console.WriteLine("1 - Mostrar vuelos");
                    Console.WriteLine("2 - Mostrar sector");
                    Console.WriteLine("3 - Mostrar ocupación");
                    Console.WriteLine("4 - Simulación");
                    Console.WriteLine("5 - Guardar y Salir");
                    i = Console.ReadLine();
                }
            }
            Console.WriteLine("Gracias y hasta pronto :)");
        }
    }
}


