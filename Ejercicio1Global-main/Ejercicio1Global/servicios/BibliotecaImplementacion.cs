using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Biblioteca bibliotecaN = nuevaBiblio();

            listaAntigua.Add(bibliotecaN);
            
        }

        private Biblioteca nuevaBiblio()
        {

            Console.WriteLine("Añade una nueva biblioteca al registro.");

            Biblioteca bibliotecaNueva = new Biblioteca();
            Console.WriteLine("Nombre de la biblioteca: ");
            bibliotecaNueva.Nombre = Console.ReadLine();

            Console.WriteLine("Dirección de la biblioteca: ");
            bibliotecaNueva.Direccion = Console.ReadLine();

            bibliotecaNueva.Id = idAutogengerado();

            return bibliotecaNueva;
            
        }

        public string bibliotecaCreada(List<Biblioteca> listaAntigua)
        {

            Console.WriteLine("Bibliotecas ya existentes");
            Biblioteca bibliotecasCreadas = new Biblioteca();

            long bibliotecaId = bibliotecaNueva().Id;

            foreach (Biblioteca biblioteca in listaAntigua)
            {
                if (biblioteca.Id.Equals(bibliotecaId))
                {
                    Console.WriteLine("Entra a la interfaz de la biblioteca " + biblioteca.Id);

                }
                else
                {
                    Console.WriteLine("El id de la biblioteca no coincide con ningún id existente");
                }

            }

           



        }

    }
}
