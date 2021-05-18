using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Norma.Web.Models
{
    public class TipoRequisitoVM
    {
        public int TipoRequisitoId { get; set; }
        [Display(Name = "Tipo de Requisito")]
        public string Descripcion { get; set; }
    }
}
