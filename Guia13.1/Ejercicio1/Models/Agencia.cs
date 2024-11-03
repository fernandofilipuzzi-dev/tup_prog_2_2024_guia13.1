using System;
using System.Collections.Generic;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Agencia
    {
        public List<Ticket> ListaAtendidos { get; set; } = new List<Ticket>();

        Queue<Cliente> nuevosCliente = new Queue<Cliente>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();

        List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        //lo nececito! para poder armar un ticket solo con los autos de la agencia.
        public Vehiculo this[string patente]
        {
            get
            {
                listaVehiculos.Sort();
                Vehiculo v = new Vehiculo(patente, null);
                int idx = listaVehiculos.BinarySearch(v);
                if(idx >= 0)
                {
                    return listaVehiculos[idx]; 
                }
                return null;
            }
        }

        public Agencia()
        {
            //dice que la agencia ya cuenta con sus vehículos!
            //no dice que los inicie cuando la aplicación se inicia (que seria el load.)
            //listaVehiculos.Add(new Vehiculo("ABC123", new Cliente("45312756")));
            //listaVehiculos.Add(new Vehiculo("ABC345", new Cliente("35122536")));
            //listaVehiculos.Add(new Vehiculo("AAA111", new Cliente("33666336")));

            //pero, como hice un método para la importación AgregarVehiculo(string nroPantente, int dniDueño)
            //la lista de vehiculo la puedo llenar al iniciar el programa
        }

        public void AgregarTicket(Ticket turno) 
        {
            if (turno != null)
            {
                if (turno is Denuncia)
                {
                    denuncias.Enqueue((Denuncia)turno);
                }
                else if (turno is Cliente)
                {
                    nuevosCliente.Enqueue((Cliente)turno);
                }
            }
        }

        public Ticket AtenderTicket(int tipo) 
        {
            Ticket atendido = null;
            if (tipo == 0)
            {
                if (denuncias.Count > 0)
                {
                    atendido = denuncias.Dequeue();
                }
            }
            else if (tipo == 1)
            {
                if (nuevosCliente.Count > 0)
                {
                    atendido = nuevosCliente.Dequeue();
                }
            }

            if (atendido!=null)
            {
                ListaAtendidos.Add(atendido);
            }
            return atendido;
        }

        //a este método lo nececito! para la importación
        public void AgregarVehiculo(string nroPantente, int dniDueño)
        {
            Vehiculo nuevo = this[nroPantente];

            if (nuevo == null)
            {
                Cliente cliente=new Cliente(nroPantente);
                nuevo = new Vehiculo(nroPantente, cliente);
                listaVehiculos.Add(nuevo);
            }
            else 
            {
                //podria pedirles que actualicen el cliente
                //pero necesitaria acceso al cliente.
            }
        }
    }
}
