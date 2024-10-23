using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using omg.models;

namespace omg.Data
{
    public class omgContext : DbContext
    {
        public omgContext (DbContextOptions<omgContext> options)
            : base(options)
        {
        }

        public DbSet<omg.models.student> student { get; set; } = default!;
        public DbSet<omg.models.teacher> teacher { get; set; } = default!;
        public DbSet<omg.models.group> group { get; set; } = default!;
        public DbSet<omg.models.subject_taught> subject_taught { get; set; } = default!;
        public DbSet<omg.models.assessmentka> assessmentka { get; set; } = default!;
    }
}
