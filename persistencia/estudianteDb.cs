using Microsoft.EntityFrameworkCore;
using modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class EstudianteDb : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }

        public EstudianteDb(DbContextOptions<EstudianteDb> options)
            :base(options)
        { }

    }
}
