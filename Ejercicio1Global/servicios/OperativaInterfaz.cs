using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaCliente(List<ClientesDto> listaClientes, List<Biblioteca> listaAntigua);

        public void darAltaLibro(List<LibrosDto> listaLibros, List<Biblioteca> listaAntigua);

        public void darAltaPrestamo(List<PrestamosDto> listaPrestamos, List<Biblioteca> listaAntigua, List<ClientesDto> listaClientes, List<LibrosDto> listaLibros);

    }
}
