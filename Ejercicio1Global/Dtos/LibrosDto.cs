using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    internal class LibrosDto
    {
        long id;
        string titulo = "aaaaa";
        string subtitulo = "aaaaa";
        string autor = "aaaaa";
        string autorN = "aaaaa";
        string autorA1 = "aaaaa";
        string autorA2 = "aaaaa";
        string ISBN = "aaaaa";
        int numeroDeLaEdición = 0;
        string editorial = "aaaaa";
        int stock = 99;

        public LibrosDto(long id, string titulo, string subtitulo, string autor, string iSBN, int numeroDeLaEdición, string editorial, int stock)
        {
            this.id = id;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.autor = autor;
            ISBN = iSBN;
            this.numeroDeLaEdición = numeroDeLaEdición;
            this.editorial = editorial;
            this.stock = stock;
            string[] arrayNombre = autor.Split(" ");
            this.autorN = arrayNombre[0];
            this.autorA1 = arrayNombre[1];
            this.autorA2 = arrayNombre[2];
        }

        public long Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string AutorN { get => autorN; set => autorN = value; }
        public string AutorA1 { get => autorA1; set => autorA1 = value; }
        public string AutorA2 { get => autorA2; set => autorA2 = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int NumeroDeLaEdición { get => numeroDeLaEdición; set => numeroDeLaEdición = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }
        

        public LibrosDto()
        {

        }


        public string ToString()
        {

            string libroN = "id: " + this.id + " Título: " + this.titulo + " Subtítulo: " + this.subtitulo + " autor: " +
                this.autor + " ISBN: " + this.ISBN + " Número de Edición: " + this.numeroDeLaEdición +
                " Editorial: " + this.editorial + " Stock: " + this.stock;

            return libroN;
        }

    }
}
