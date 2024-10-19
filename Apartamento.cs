using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRefugioDelSolObligatorio
{
    internal class Apartamento
    {
        public int UltimoId {  get; set; }
        public int NumeroApartamento { get; set; }
        public int NumeroDormitorios { get; set; }
        public string[,] Ubicacion { get; set; }
        public int Precio { get; set; }
        public bool Disponibilidad { get; set; }

        public int NuevoId(int id)
        {
            UltimoId = id;
            return UltimoId;

        }

    }
}