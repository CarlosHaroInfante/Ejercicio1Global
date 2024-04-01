using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
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

        }

    }
}
