using Ejercicio1Global.Dtos;
using Ejercicio1Global.servicios;
using Ejercicio1Global.controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Immutable;

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

            bibliotecaN.Id = idAutogengerado(listaAntigua);

            Console.WriteLine("Nombre de la biblioteca: ");
            bibliotecaN.Nombre = Console.ReadLine();

            Console.WriteLine("Dirección de la biblioteca: ");
            bibliotecaN.Direccion = Console.ReadLine();

            listaAntigua.Add(bibliotecaN);

            Console.WriteLine("id:" + bibliotecaN.Id);
        }

        public void bibliotecaExistente(List<Biblioteca> listaAntigua)
        {
            Biblioteca bibliotecaExiste = new Biblioteca();

            Console.WriteLine(bibliotecaExiste.Id);
            
            Console.WriteLine("Biblioteca existente, ingrese en id de la biblioteca para entrar");

            long idBE = Convert.ToInt64(Console.ReadLine());

            if (idBE.Equals(bibliotecaExiste.Id))
            {
              
                bool cerrarMenu = true;

                while (!cerrarMenu)
                {
                    MenuInterfaz menu = new MenuImplementacion();
                    int menuBiblio = menu.menuParaBibliotecas();
                   
                    switch (menuBiblio)
                    {

                        case 0:
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Dar de alta un nuevo cliente");
                            break;
                        case 2:
                            Console.WriteLine("Dar de alta un nuevo libro");
                            break;
                        case 3:
                            Console.WriteLine("Dar de alta un nuevo prestamo");
                            break;
                        default:
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
