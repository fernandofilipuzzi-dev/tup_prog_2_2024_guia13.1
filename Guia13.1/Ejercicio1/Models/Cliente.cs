using System;
using System.Diagnostics;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Cliente:Ticket
    {
        private long dni;

        static int numero;

        public int TipoVehiculo { get; set; }

        public Cliente(string dni)
        {
            nroOrden = ++numero;

            bool hayNumeros = dni.Length != 0;
            for (int n = 0; n < dni.Length && hayNumeros==true; n++)
            {
                hayNumeros &= char.IsNumber(dni[n]) == true;
            }
            if(hayNumeros==false) 
                throw new DniNoValidoException("Hay caracteres no numéricos");

            this.dni = Convert.ToInt64( dni);//lanzar excepcion

            if (this.dni < 5000000) 
                throw new DniNoValidoException("El DNI debe ser mayor a 5000000");
        }

        public override string ToString() 
        {
            return $"CLIENTE;{base.ToString()};{dni}";
        }
    }
}
