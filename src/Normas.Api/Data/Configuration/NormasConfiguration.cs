using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Normas.Api.Models.Configuration
{
    public class NormasConfiguration
    {
        public NormasConfiguration(EntityTypeBuilder<Norma> entityBuilder)
        {
            entityBuilder.HasKey(x => x.NormaID);
            entityBuilder.Property(x => x.Clave).IsRequired().HasMaxLength(20);
            entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);

            var lista = new List<Norma>();

            lista.Add(new Norma
            {
                NormaID = 1,
                Clave = "abc123",
                Descripcion = "descripcion",
                Activo = true,
                FechaPublicacion = DateTime.Now,
                TipoRequisitoId = 1
            });

            entityBuilder.HasData(lista);

        }
    }
}
