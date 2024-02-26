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
            StreamReader reader = new StreamReader("vuelos.txt");
            string texto = reader.ReadToEnd();
            string[] vuelos = texto.Split(" / ");
        }
    }
}
