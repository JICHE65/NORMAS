using System;
using System.ComponentModel.DataAnnotations;

namespace Norma.Web.Models
{
    public class NormaVM
    {
        public int NormaID { get; set; }
        public string Clave { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Publicación")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaPublicacion { get; set; }
        public Boolean Activo { get; set; }
        public int TipoRequisitoId { get; set; }
        public TipoRequisitoVM Requisito { get; set; }
    }
}
