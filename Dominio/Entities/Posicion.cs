using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Posicion : BaseEntity
    {
        public string NombrePosicion { get; set; }
        public ICollection<Jugador> Jugadores { get; set; }
    }
}