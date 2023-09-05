
namespace Dominio.Entities;

    public class Persona : BaseEntity
    {
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public int Edad{ get; set; }
        public int IdTipoNominaFk{get; set; }
        public TipoNomina TipoNomina{ get; set; }
        public int IdEquipoFk{get; set; }
        public Equipo Equipo{ get; set; }  
        public Jugador Jugador{ get; set; }

    }
