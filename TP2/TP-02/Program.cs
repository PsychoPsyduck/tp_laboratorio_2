using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_2018;

namespace TP_02_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2);

            // Nombre del alumno
            Console.Title = "Sande Nicolas Alejandro 2°C";

            Changuito changoDeCompras = new Changuito(6);

            Dulce d1 = new Dulce(Producto.EMarca.Sancor, "ASD012", ConsoleColor.Black);
            Dulce d2 = new Dulce(Producto.EMarca.Ilolay, "ASD913", ConsoleColor.Red);
            Leche l1 = new Leche(Producto.EMarca.Pepsico, "HJK789", ConsoleColor.White);
            Leche l2 = new Leche(Producto.EMarca.Serenisima, "IOP852", ConsoleColor.Blue, Leche.ETipo.Descremada);
            Snacks s1 = new Snacks(Producto.EMarca.Campagnola, "QWE968", ConsoleColor.Gray);
            Snacks s2 = new Snacks(Producto.EMarca.Arcor, "TYU426", ConsoleColor.DarkBlue);
            Snacks s3 = new Snacks(Producto.EMarca.Sancor, "IOP852", ConsoleColor.Green);
            Snacks s4 = new Snacks(Producto.EMarca.Sancor, "TRE321", ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            changoDeCompras += d1;
            changoDeCompras += d2;
            changoDeCompras += l1;
            changoDeCompras += l1;
            changoDeCompras += l2;
            changoDeCompras += s1;
            changoDeCompras += s2;
            changoDeCompras += s3;
            changoDeCompras += s4;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Beep(14000, 1000);
            Console.Clear();

            // Quito un item y muestro
            changoDeCompras -= d1;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            // Muestro solo Leches
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Leche));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            // Muestro solo Dulces
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Dulce));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            // Muestro solo Snacks
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Snacks));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey();
            Console.Beep(14000, 1000);
        }
    }
}
