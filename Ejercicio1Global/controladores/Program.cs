using Ejercicio1Global.servicios;
using Ejercicio1Global.Dtos;

namespace Ejercicio1Global.controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();
            List<ClientesDto> clientes = new List<ClientesDto>();
            List<LibrosDto> libros = new List<LibrosDto>();
            List<PrestamosDto> prestamos = new List<PrestamosDto>();
            MenuInterfaz menu = new MenuImplementacion();
            BibliotecaInterfaz bibliotecas = new BibliotecaImplementacion();

            bool cerrarMenu = false;

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
                        bibliotecas.bibliotecaNueva(biblioteca);
                        break;
                    case 2:
                        Console.WriteLine("Biblioteca Existente");
                        bibliotecas.bibliotecaExistente(biblioteca);
                        break;
                    default:
                        Console.WriteLine("Opción seleccionada erroneamente, intentelo de nuevo.");
                        break;
                }
            }


        }
    }
}



