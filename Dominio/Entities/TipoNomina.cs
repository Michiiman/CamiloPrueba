using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class TipoNomina : BaseEntity
    {
        public string NombreNomina { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
}