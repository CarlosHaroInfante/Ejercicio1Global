using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.servicios
{
    internal class BibliotecaImplementacion : BibliotecaInterfaz
    {
        private long idAutogengerado(List<Biblioteca> listaAntigua)
        {

            long idAuto;
            int tamanio = listaAntigua.Count;

            if (listaAntigua.Count == 0)
            {
                idAuto = 1;
            }
            else
            {
                idAuto = listaAntigua[tamanio - 1].Id + 1;
            }
            return idAuto;
        }
        public void bibliotecaNueva(List<Biblioteca> listaAntigua)
        {
            Biblioteca bibliotecaN = new Biblioteca();
            Console.WriteLine("Biblioteca Nueva, ingrese los siguientes datos: ");

            long id = idAutogengerado(listaAntigua);
            bibliotecaN.Id = id;

            Console.WriteLine("Nombre de la biblioteca: ");
            string nombreBiblio = Console.ReadLine();
            bibliotecaN.Nombre = nombreBiblio;

            Console.WriteLine("Dirección de la biblioteca: ");
            string direccion = Console.ReadLine();
            bibliotecaN.Direccion = direccion;

            listaAntigua.Add(bibliotecaN);

        }

        public void bibliotecaExistente(List<Biblioteca> listaAntigua, List<ClientesDto> listaClientes, List<LibrosDto> listaLibros)
        {
            MenuInterfaz menu = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();
           
            foreach (Biblioteca bibliotecasid in listaAntigua)
            {

                Console.WriteLine(bibliotecasid.ToString());
            }
            
            Console.WriteLine("Biblioteca existente, ingrese en id de la biblioteca para entrar");

            long idBE = Convert.ToInt64(Console.ReadLine());
            

            foreach (Biblioteca bibliotecas in listaAntigua)
            {
    

                if (idBE.Equals(bibliotecas.Id))
                {
                    Console.WriteLine("Entrando en la biblioteca: " + bibliotecas.Nombre);

                    bool cerrarMenu = false;

                    while (!cerrarMenu)
                    {
                        int num = menu.menuParaBibliotecas();

                        switch (num)
                        {
                            case 0:
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("Alta Cliente: ");
                                op.darAltaCliente(listaClientes, listaAntigua);
                                break;
                            case 2:
                                Console.WriteLine("Alta Libro: ");
                                op.darAltaLibro(listaLibros, listaAntigua);
                                break;
                            case 3:
                                Console.WriteLine("Alta Prestamo: ");
                                break;
                            case 4:
                                Console.WriteLine("Entrega libro");
                                break;
                            case 5:
                                Console.WriteLine("Libros de la biblioteca");
                                break;
                            default:
                                Console.WriteLine("Ninguna opción válida");
                                break;


                        }


                    }

                }
                else
                {
                    Console.WriteLine("Ninguna biblioteca coincide con el id ingresado");
                }

            }

        }



    }
}
