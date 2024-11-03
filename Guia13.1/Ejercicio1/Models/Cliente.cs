using System;

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
            this.dni = Convert.ToInt64( dni);//lanzar excepcion
        }

        public override string ToString() 
        {
            return $"CLIENTE;{base.ToString()};{dni}";
        }
    }
}
