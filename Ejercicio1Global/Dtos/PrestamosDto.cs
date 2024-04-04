using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    internal class PrestamosDto
    {
        long id;
        long identificadorDelPrestamo;
        long identificadorDelCliente;
        long identificadorDelLibro;
        DateOnly fechaDePrestamo;
        DateOnly fechaDeEntrega;
        string estadoDelPrestamo = "aaaaa";

        public PrestamosDto(long id, long identificadorDelPrestamo, long identificadorDelCliente, long identificadorDelLibro, DateOnly fechaDePrestamo, DateOnly fechaDeEntrega, string estadoDelPrestamo)
        {
            this.id = id;
            this.identificadorDelPrestamo = identificadorDelPrestamo;
            this.identificadorDelCliente = identificadorDelCliente;
            this.identificadorDelLibro = identificadorDelLibro;
            this.fechaDePrestamo = fechaDePrestamo;
            this.fechaDeEntrega = fechaDeEntrega;
            this.estadoDelPrestamo = estadoDelPrestamo;
        }

        public long Id { get => id; set => id = value; }
        public long IdentificadorDelPrestamo { get => identificadorDelPrestamo; set => identificadorDelPrestamo = value; }
        public long IdentificadorDelCliente { get => identificadorDelCliente; set => identificadorDelCliente = value; }
        public long IdentificadorDelLibro { get => identificadorDelLibro; set => identificadorDelLibro = value; }
        public DateOnly FechaDePrestamo { get => fechaDePrestamo; set => fechaDePrestamo = value; }
        public DateOnly FechaDeEntrega { get => fechaDeEntrega; set => fechaDeEntrega = value; }
        public string EstadoDelPrestamo { get => estadoDelPrestamo; set => estadoDelPrestamo = value; }


        public string ToString()
        {

            string prestamoN = "id: " + this.id + " idPrestamo: " + this.identificadorDelPrestamo +
                " idCliente: " + this.identificadorDelCliente + " idLibro: " +
                this.identificadorDelLibro + " FchaPrestamo: " + this.fechaDePrestamo +
                " FchaEntrega: " + this.fechaDeEntrega +
                " Estado del prestamo: " + this.estadoDelPrestamo;

            return prestamoN;
        }
    }
}
