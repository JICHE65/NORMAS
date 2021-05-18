using System;

namespace Normas.Api.Models
{
    public class Norma
    {
        public int NormaID { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Boolean Activo { get; set; }
        public int TipoRequisitoId { get; set; }
        public TipoRequisito Requisito { get; set; }
    }
}
