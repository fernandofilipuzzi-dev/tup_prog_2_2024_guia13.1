using System;
using System.Collections.Generic;

namespace Ejercicio1.Models
{
    [Serializable]
    abstract public class Ticket
    {
        protected int nroOrden;
        DateTime fechaHora;

        public Ticket()
        { 
            fechaHora = DateTime.Now;
        }

        public int VerNro() 
        {
            return nroOrden;
        }

        public DateTime VerFechaHora()
        { 
            return fechaHora;
        }

        override public string ToString()
        {
            return $"{VerNro()};{VerFechaHora():d/M/yyyy}";
        }
    }
}
