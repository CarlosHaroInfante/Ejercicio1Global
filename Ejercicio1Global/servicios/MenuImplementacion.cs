using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuBiblioteca()
        {
            Console.WriteLine("Bibliotecas");
            Console.WriteLine("///////////");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Crear una nueva Biblioteca");
            Console.WriteLine("[2] - Entrar en una biblioteca específica");
            Console.WriteLine("///////////");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;

        }

        public int menuParaBibliotecas()
        {
            Console.WriteLine("Opciones de la biblioteca");
            Console.WriteLine("///////////");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Dar de alta un nuevo cliente");
            Console.WriteLine("[2] - Dar de alta un nuevo préstamo");
            Console.WriteLine("[3] - Dar de alta un nuevo libro");
            Console.WriteLine("[4] - Entrega de Libro");
            Console.WriteLine("[5] - Libros de la biblioteca");
            Console.WriteLine("///////////");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;

        }
    }
}
