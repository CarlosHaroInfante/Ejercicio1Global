using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1Global.Dtos
{
    internal class ClientesDto
    {
        long id;
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        DateTime FechaDeNacimiento = new DateTime(31, 12, 9999);
        string dni = "aaaaa";
        string correoElectronico = "aaaaa";
        DateTime fechaInicioSuspension = new DateTime(31, 12, 9999);
        DateTime fechaFinSuspensión = new DateTime(31, 12, 9999);

        public ClientesDto(long id, string nombre, string apellidos, DateTime fechaDeNacimiento, string dni, string correoElectronico, DateTime fechaInicioSuspension, DateTime fechaFinSuspensión)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            FechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
            this.correoElectronico = correoElectronico;
            this.fechaInicioSuspension = fechaInicioSuspension;
            this.fechaFinSuspensión = fechaFinSuspensión;
            string[] apellidosJuntos = apellidos.Split();
            this.apellido1 = apellidosJuntos[0];
            this.apellido2 = apellidosJuntos[1];
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public DateTime FechaDeNacimiento1 { get => FechaDeNacimiento; set => FechaDeNacimiento = value; }
        public string Dni { get => dni; set => dni = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public DateTime FechaInicioSuspension { get => fechaInicioSuspension; set => fechaInicioSuspension = value; }
        public DateTime FechaFinSuspensión { get => fechaFinSuspensión; set => fechaFinSuspensión = value; }
    

    public ClientesDto()
        {

        }
    public string ToString()
    {
            string clienteD = "id: " + this.id + " nombre: " + this.nombre + " apellidos: " + this.apellidos
                    + " DNI: " + this.dni + " Fch Nacimiento: " + this.FechaDeNacimiento +
                    " correoE: " + this.correoElectronico + " Fch Suspensión " + fechaInicioSuspension
                    + " Fch Fin Suspensión: " + fechaFinSuspensión;

            return clienteD;
    }
    
    }
}
