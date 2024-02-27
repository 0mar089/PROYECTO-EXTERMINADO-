using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avion;
using Sector;
using ListaDeVuelos;

namespace Menú
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            CListaDeVuelos vuelos = new CListaDeVuelos();

            while (true)
            {
                Console.WriteLine("Escoje una opción:");
                Console.WriteLine("1_Mostrar vuelos");
                Console.WriteLine("2_Escoje una opción:");
                Console.WriteLine("3_Escoje una opción:");
                Console.WriteLine("4_Escoje una opción:");
                Console.WriteLine("5_Escoje una opción:");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

