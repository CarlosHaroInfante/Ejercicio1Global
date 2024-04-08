using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void darAltaCliente(List<ClientesDto> listaClientes, List<Biblioteca> listaAntigua)
        {
            ClientesDto clienteN = new ClientesDto();
            Biblioteca bibliotecaid = new Biblioteca();

            Console.WriteLine("Apellidos del Cliente Nuevo: ");
            clienteN.Apellidos = Console.ReadLine();

            Console.WriteLine("Nombre del Cliente Nuevo: ");
            clienteN.Nombre = Console.ReadLine();

            Console.WriteLine("Fecha de Nacimiento: ");
            clienteN.FechaDeNacimiento1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("DNI: ");
            clienteN.Dni = Console.ReadLine();

            Console.WriteLine("Correo Electrónico: ");
            clienteN.CorreoElectronico = Console.ReadLine();

            clienteN.BibliotecaId = bibliotecaid.Id;

            clienteN.Id = idAutogengerado(listaClientes);
            
            listaClientes.Add(clienteN);
        }

        public void darAltaLibro(List<LibrosDto> listaLibros, List<Biblioteca> listaAntigua)
        {
            LibrosDto altaLibro = new LibrosDto();
            Biblioteca bibliotecaid = new Biblioteca();

            altaLibro.Id = idAutogengeradoLibros(listaLibros);

            Console.WriteLine("Título del libro");
            altaLibro.Titulo = Console.ReadLine();

            Console.WriteLine("Subtitulo");
            altaLibro.Subtitulo = Console.ReadLine();

            Console.WriteLine("Autor");
            altaLibro.Autor = Console.ReadLine();

            Console.WriteLine("ISBN");
            altaLibro.ISBN1 = Console.ReadLine();

            Console.WriteLine("Numero de edición del libro");
            altaLibro.NumeroDeLaEdición = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Editorial");
            altaLibro.Editorial = Console.ReadLine();

            Console.WriteLine("Stock");
            altaLibro.Stock = Convert.ToInt32(Console.ReadLine());

            altaLibro.BibliotecaId = bibliotecaid.Id;


            listaLibros.Add(altaLibro);

        }

        public void darAltaPrestamo(List<PrestamosDto> listaPrestamos, List<Biblioteca> listaAntigua, List<ClientesDto> listaClientes, List<LibrosDto> listaLibros)
        {
            Biblioteca bibliotecaId = new Biblioteca();
            PrestamosDto prestamosN = new PrestamosDto();

            prestamosN.IdentificadorDelPrestamo = idAutogengeradoPrestamos(listaPrestamos);

           

            prestamosN.IdentificadorDelCliente = idAutogengerado(listaClientes);

            
            prestamosN.IdentificadorDelLibro = idAutogengeradoLibros(listaLibros);

            Console.WriteLine("Fecha del Prestamo");
            prestamosN.FechaDePrestamo = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Fecha de Entrega");
            prestamosN.FechaDeEntrega = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Estado del Prestamo");
            prestamosN.EstadoDelPrestamo = Console.ReadLine();

            prestamosN.BibliotecaId = bibliotecaId.Id;



        }

        private long idAutogengerado(List<ClientesDto> listaClientes)
        {

            long idAuto;
            int tamanio = listaClientes.Count;

            if (listaClientes.Count == 0)
            {
                idAuto = 1;
            }
            else
            {
                idAuto = listaClientes[tamanio - 1].Id + 1;
            }
            return idAuto;
        }
        private long idAutogengeradoLibros(List<LibrosDto> listaLibros)
        {

            long idAuto;
            int tamanio = listaLibros.Count;

            if (listaLibros.Count == 0)
            {
                idAuto = 1;
            }
            else
            {
                idAuto = listaLibros[tamanio - 1].Id + 1;
            }
            return idAuto;
        }
        private long idAutogengeradoPrestamos(List<PrestamosDto> listaPrestamos)
        {

            long idAuto;
            int tamanio = listaPrestamos.Count;

            if (listaPrestamos.Count == 0)
            {
                idAuto = 1;
            }
            else
            {
                idAuto = listaPrestamos[tamanio - 1].IdentificadorDelPrestamo + 1;
            }
            return idAuto;
        }
    }
}
