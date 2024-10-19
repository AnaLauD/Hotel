using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRefugioDelSolObligatorio
{
    internal class Reserva
    {
        public int UltimoId { get; set; }
        public int IdReserva { get; set; }
        public int CantidadValijas { get; set; }
        public List<Huesped> Huespedes { get; set; }
        public Apartamento[] Apartamentos { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva ()
        {
            Huespedes  = new List<Huesped> ();
        }

        public int NuevoId (int Id)
        {
            Id = UltimoId;
            return UltimoId;
        }
    }
}
