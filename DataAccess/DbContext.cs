using Microsoft.EntityFrameworkCore;
using PortFol.Models;

namespace PortFol.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor: Recibe la configuración de conexión
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ====================================================
        // DbSet: Propiedades que mapean a las tablas de la BD
        // ====================================================
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<FODAItem> FODAItems { get; set; }
        public DbSet<FAQ> FAQs { get; set; }

        // El DbSet de la tabla de unión NO es necesario si se configura la relación, 
        // pero es buena práctica listarla para mayor claridad.
        public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Configuración de la llave compuesta de la tabla Muchos a Muchos
            modelBuilder.Entity<ProjectTechnology>()
                .HasKey(pt => new { pt.ProjectId, pt.TechnologyId });

            // 2. Definición de la relación de la llave foránea Project
            modelBuilder.Entity<ProjectTechnology>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.ProjectTechnologies)
                .HasForeignKey(pt => pt.ProjectId);

            // 3. Definición de la relación de la llave foránea Technology
            modelBuilder.Entity<ProjectTechnology>()
                .HasOne(pt => pt.Technology)
                .WithMany(t => t.ProjectTechnologies)
                .HasForeignKey(pt => pt.TechnologyId);

            // Llamada al método base para asegurar la configuración por defecto de EF Core
            base.OnModelCreating(modelBuilder);
        }
    }
}
