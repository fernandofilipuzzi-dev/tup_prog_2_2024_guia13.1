using System;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Vehiculo:IComparable<Vehiculo>
    {
        string nroPatente;
        Cliente dueño;

        public Vehiculo(string patente, Cliente dueño)
        {
            nroPatente = patente;
            this.dueño = dueño;
        }

        public Cliente VerDueño()
        {
            return dueño;
        }

        string VerPatente() 
        {
            return nroPatente;
        }

        public int CompareTo(Vehiculo other)
        {
            if (other != null)
                return nroPatente.CompareTo(other.nroPatente);
            return 1;
        }

        public override string ToString()
        {
            return $"{nroPatente}";
        }
    }
}
