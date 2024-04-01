using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    internal class Biblioteca
    {
        long id;

        string nombre = "aaaaa";

        string direccion = "aaaaa";

        

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
       public Biblioteca(long id, string nombre, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public string ToString()
        {

            string nom = "id: " + this.id + "nombre: " + this.Nombre + "dirección: " + this.Direccion;
            return nom;
        }


    
    }
}
