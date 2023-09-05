

namespace Dominio.Entities;

    public class Pais : BaseEntity
    {
        public string NombrePais{ get; set; }
        public ICollection<Equipo> Equipos{ get; set; }

    }
