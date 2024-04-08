using Ejercicio1Global.servicios;
using Ejercicio1Global.Dtos;

namespace Ejercicio1Global.controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();
            MenuInterfaz menu = new MenuImplementacion();
            BibliotecaInterfaz biblio = new BibliotecaImplementacion();

            bool cerrarMenu = true;

            while (!cerrarMenu)
            {
                int op = menu.menuBiblioteca();

                switch (op)
                {

                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Añadir nueva biblioteca");
                        biblio.bibliotecaNueva(biblioteca);
                        break;
                    case 2:
                        Console.WriteLine("Biblioteca Existente");
                        biblio.bibliotecaCreada(biblioteca);
                        break;
                    default:
                        Console.WriteLine("Opción seleccionada erroneamente, intentelo de nuevo.");
                        break;
                }
            }


        }
    }
}



