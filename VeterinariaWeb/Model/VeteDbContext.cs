using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VeterinariaWeb.Model
{
    public partial class VeteDbContext : DbContext
    {
        public VeteDbContext()
        {
        }

        public virtual DbSet<Animal> Animales { get; set; }
        public virtual DbSet<Pacient> Pacientes { get; set; }

        public VeteDbContext(DbContextOptions<VeteDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
