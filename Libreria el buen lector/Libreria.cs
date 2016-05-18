using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_el_buen_lector
{
    class Libreria
    {
        String nombre = "";
        int numTel = 0;

        public void InformacionPersonal()
        {
            try
            {
                Console.Write("Digite su nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Bienvenido, " + nombre);
                Console.Write("Digite su numero de telefono: ");
                numTel = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Su numero telefonico debe ir todo junto sin ningun tipo de espacio o letra");

            }

        }
        public void Menu(){
             Console.WriteLine("Cual(es) libro(s) desea comprar de la siguiente lista: ");
            Console.WriteLine();
            Console.WriteLine("1- El Señor de los anillos. Las dos torres. (Fantasia) ");
            Console.WriteLine("2- Alicia en el pais de las maravillas. (Infantil)");
            Console.WriteLine("3- Cemeterio de mascotas.(Misterio)");
            Console.WriteLine("4- Quiero aprender. (Educativo)");
            Console.WriteLine("5- El poder del pensamiento positivo. (Superacion)");
            Console.WriteLine("6- Mi primer libro de matemáticas. (Educativo)");
            Console.WriteLine("7- Las aventuras de Tom Sawyer. (Infantil)");
            Console.WriteLine("8- El mago de Oz. (Fantasia)");
            Console.WriteLine("9- La zona muerta. (Misterio)");
            Console.WriteLine("10- Viaje al centro de la tierra. (Ciencia Ficcion)");
        }
        public void selecLibro()
        {
            int precio = 0;
            int tipoLib = 0;
            int cantLib = 0;
            int desc = 0;
            int totLib = 0;
            int montoPagar = 0;
            double montdesc = 0;
            double cambio = 0;
            double montoNeto = 0;
            
            try
            {
                Console.Write("Digite que libro desea comprar indicando su respectivo numero de acuerdo a la lista: ");
                tipoLib = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe digitar un numero entre el 1 y 10.");

            }
            
            if (tipoLib == 1)
            {
                 precio = 8000;
                 desc = 3;
                
            }
            else if (tipoLib == 2)
            {
                 precio = 8000;
                 desc = 1; 
            }
            else if (tipoLib == 3)
            {
                 precio = 8000;
                 desc = 2; 

            }
            else if (tipoLib == 4)
            {
                precio = 1000;
                desc = 4; 
                
            }
            else if (tipoLib == 5)
            {
                precio = 9000;
                desc = 5; 
                
            }
            else if (tipoLib == 6)
            {
                precio = 7000;
                desc = 4; 
                
            }
            else if (tipoLib == 7)
            {
                precio = 2000;
                desc = 1; 
                
            }
            else if (tipoLib == 8)
            {
                precio = 6000;
                desc = 3; 
                
            }
            else if (tipoLib == 9)
            {
                precio = 3000;
                desc = 2; 
                
            }
            else if (tipoLib == 10)
            {
                precio = 5000;
                desc = 5; 
                
            }
            else
            {
                Console.WriteLine("El libro seleccionado no se encuentra en la lista. ");
            }
            Console.WriteLine();
            Console.Write("Cuantos Libros desea comprar de cada titulo: ");
            cantLib = int.Parse(Console.ReadLine());
            totLib = cantLib * precio;
            Console.WriteLine("El monto a pagar sin descuento es: " + totLib);
            Console.WriteLine();
            if (desc == 1)
            {
                montdesc = totLib - 0.05;
            }
            if (desc == 2)
            {
                montdesc = totLib - 0.1;
            }
            if (desc == 3)
            {
                montdesc = totLib - 0.15;
            }
            if (desc == 4)
            {
                montdesc = totLib - 0.2;
            }
            if (desc == 5)
            {
                montdesc = totLib - 0.25;
            }
            montoNeto = montdesc - totLib;
            Console.WriteLine("Ingrese el monto con el cual pagara los libros: ");
            montoPagar = int.Parse(Console.ReadLine());
            cambio = montoPagar - montoNeto;


        }
        public void Factura()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("*.*         Libreria El Buen Lector          *.*");
            Console.WriteLine("================================================");
            Console.WriteLine("Factura Proforma                               N");
            Console.WriteLine("Cliente: "+nombre);
            Console.WriteLine("Telefono: " + numTel);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("item           Ctd         Precio      SubTotal ");
            Console.WriteLine("");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");



        }
        
        }

    }

