using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menú
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
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
