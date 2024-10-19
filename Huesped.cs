using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRefugioDelSolObligatorio
{
    internal class Huesped
    {
        public int UltimaId { get; set; }
        public int HuespedId { get; set; }
        public string Nombre { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Huesped()
        {
            Reservas = new List<Reserva>();
        }
        public int NuevoId (int id)
        {
            UltimaId = id;
            return UltimaId;
           
        }

    }
}
