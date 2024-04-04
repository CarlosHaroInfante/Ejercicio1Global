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

        public void darAltaCliente(List<ClientesDto> listaClientes)
        {
            ClientesDto clienteN = new ClientesDto();
            BibliotecaInterfaz idAunto = new BibliotecaImplementacion();

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

            Console.WriteLine("Fecha Inicio Suspensión: ");
            clienteN.FechaInicioSuspension = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Fecha Fin Suspensión: ");
            clienteN.FechaFinSuspensión = Convert.ToDateTime(Console.ReadLine());

            clienteN.Id = idAutogengerado(listaClientes);
            
            listaClientes.Add(clienteN);
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
    }
}
