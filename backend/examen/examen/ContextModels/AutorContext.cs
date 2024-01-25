using examen.Models;
using Microsoft.EntityFrameworkCore;

namespace examen.ContextModels
{
    public class AutorContext : DbContext
    {
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Carte> Carte { get; set; }
        public DbSet<Editura> Editura { get; set; }
        public DbSet<AutorCarte> AutoriCarti { get; set; }
        public AutorContext(DbContextOptions<AutorContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Editura>()
                .HasMany(aut => aut.Autori)
                .WithOne(edit => edit.Editura);

            modelBuilder.Entity<AutorCarte>().HasKey(autcar => new { autcar.AutorId, autcar.CarteId });

            modelBuilder.Entity<AutorCarte>()
                        .HasOne(autcar => autcar.Autor)
                        .WithMany(aut => aut.AutoriCarti)
                        .HasForeignKey(autcar => autcar.AutorId);

            modelBuilder.Entity<AutorCarte>()
                        .HasOne(autcar => autcar.Carte)
                        .WithMany(car => car.AutoriCarti)
                        .HasForeignKey(autcar => autcar.CarteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
