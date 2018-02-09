using bscitgroup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bscitgroup.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new bscitgroupContext(
                serviceProvider.GetRequiredService<DbContextOptions<bscitgroupContext>>()))
            {
                var categorias = new List<Categorias>
                {
                    new Categorias
                    {
                        Nombre = "Educación"
                    },
                    new Categorias
                    {
                        Nombre = "Desarrollo"
                    }

                };
                context.Categorias.AddRange(categorias);
                context.SaveChanges();
                var personas = new List<Persona>
                {
                    new Persona
                    {
                        DNI = 78961245,
                        Apellido = "A1",
                        Nombre = "N1",
                        Celular = "987452612",
                        Ciudad = "Arequipa",
                        Pais = "Peru",
                        Correo = "c@correo.com",
                        Profesion = "Docente",
                        Institucion = "I1",
                        Telefono = "7894561320",
                        Intereses = categorias,          
                    }
                };
                context.Persona.AddRange(personas);
                context.SaveChanges();
            }
        }
    }
}