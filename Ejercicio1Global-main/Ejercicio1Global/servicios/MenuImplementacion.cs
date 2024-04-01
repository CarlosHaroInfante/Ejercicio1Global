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
    }
}
