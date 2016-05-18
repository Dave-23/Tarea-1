using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_el_buen_lector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Libreria El Buen Lector ");
            Libreria Lib = new Libreria();
            Lib.InformacionPersonal();
            Lib.Menu();
            Console.WriteLine();
            Lib.selecLibro();
            Console.WriteLine();
            Lib.Factura();
            Console.ReadKey();
          

       }  
    }
}
