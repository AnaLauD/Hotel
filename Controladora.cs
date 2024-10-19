using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRefugioDelSolObligatorio
{
    internal class Controladora
    {
        public List<Huesped> Huespedes { get; set; }
        public List<Apartamento> Apartamentos { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Controladora()
        {
            Huespedes = new List<Huesped>();
            Apartamentos = new List<Apartamento>();
            Reservas = new List<Reserva>();
        }

        public void MostrarReservas(Reserva reserva)
        {
            foreach (Reserva reservas in Reservas)
            {
                Console.WriteLine(reservas.ToString());
            }
        }

        public bool AgregarReserva(Reserva reserva)
        {
            if (reserva != null)
            {

                Reservas.Add(reserva);
                return true;
            }
            else
            {
                Console.WriteLine("La reserva ya existe");
                return false;
            }
        }

        public bool EditarReserva(int idReserva, Reserva nuevaReserva)
        {
            if (nuevaReserva != null)
            {
                var reservaExistente = Reservas.FirstOrDefault(r => r.IdReserva == idReserva);
                if (reservaExistente != null)
                {
                    reservaExistente.CantidadValijas = nuevaReserva.CantidadValijas;
                    reservaExistente.Apartamentos = nuevaReserva.Apartamentos;
                    reservaExistente.FechaReserva = nuevaReserva.FechaReserva;

                    return true;
                }
                else
                {
                    Console.WriteLine("No se encontro la reserva");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Hubo un error con la reserva");
                return false;
            }
        }
        public bool CancelarReserva(Reserva reserva)
        {
            if (reserva != null)
            {
                if (Reservas.Contains(reserva)) 
                {
                    Reservas.Remove(reserva);
                    Console.WriteLine("Reserva eliminada");
                    return true; 
                }
                else
                {
                    Console.WriteLine("No encontramos la reserva");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No existe la reserva");
                return false; 
            }
        }

    }
}
     
