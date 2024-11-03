using System;
using System.Collections;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Denuncia:Ticket
    {
        Vehiculo dominio;

        static int numero;

        public Denuncia(Vehiculo asegurado)
        {
            nroOrden = ++numero;
            this.dominio=asegurado;
        }


        override public string ToString()
        {
            return $"DENUNCIA;{base.ToString()};{dominio.ToString()}";
        }
    }
}

