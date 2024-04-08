using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    internal class PrestamosDto
    {
        
        long identificadorDelPrestamo;
        long identificadorDelCliente;
        long identificadorDelLibro;
        DateTime fechaDePrestamo = new DateTime(9999, 12, 31);
        DateTime fechaDeEntrega = new DateTime(9999, 12, 31);
        string estadoDelPrestamo = "aaaaa";
        long bibliotecaId;

        public PrestamosDto()
        {
        }

        public PrestamosDto(long identificadorDelPrestamo, long identificadorDelCliente, long identificadorDelLibro, DateTime fechaDePrestamo, DateTime fechaDeEntrega, string estadoDelPrestamo, long bibliotecaId)
        {
            
            this.identificadorDelPrestamo = identificadorDelPrestamo;
            this.identificadorDelCliente = identificadorDelCliente;
            this.identificadorDelLibro = identificadorDelLibro;
            this.fechaDePrestamo = fechaDePrestamo;
            this.fechaDeEntrega = fechaDeEntrega;
            this.estadoDelPrestamo = estadoDelPrestamo;
            this.bibliotecaId = bibliotecaId;
        }

       
        public long IdentificadorDelPrestamo { get => identificadorDelPrestamo; set => identificadorDelPrestamo = value; }
        public long IdentificadorDelCliente { get => identificadorDelCliente; set => identificadorDelCliente = value; }
        public long IdentificadorDelLibro { get => identificadorDelLibro; set => identificadorDelLibro = value; }
        public DateTime FechaDePrestamo { get => fechaDePrestamo; set => fechaDePrestamo = value; }
        public DateTime FechaDeEntrega { get => fechaDeEntrega; set => fechaDeEntrega = value; }
        public string EstadoDelPrestamo { get => estadoDelPrestamo; set => estadoDelPrestamo = value; }

        public long BibliotecaId { get => bibliotecaId; set => bibliotecaId = value; }


        public string ToString()
        {

            string prestamoN = "IdPrestamo: " + this.identificadorDelPrestamo +
                " idCliente: " + this.identificadorDelCliente + " idLibro: " +
                this.identificadorDelLibro + " FchaPrestamo: " + this.fechaDePrestamo +
                " FchaEntrega: " + this.fechaDeEntrega +
                " Estado del prestamo: " + this.estadoDelPrestamo + " BibliotecaId " + bibliotecaId;

            return prestamoN;
        }
    }
}
