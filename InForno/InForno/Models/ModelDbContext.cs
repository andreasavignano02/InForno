using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InForno.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<AmministratoriTab> AmministratoriTab { get; set; }
        public virtual DbSet<CarelloTab> CarelloTab { get; set; }
        public virtual DbSet<ListaPizze> ListaPizze { get; set; }
        public virtual DbSet<OrdineTab> OrdineTab { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UtentiTab> UtentiTab { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarelloTab>()
                .Property(e => e.PrezzoTotale)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ListaPizze>()
                .Property(e => e.Prezzo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ListaPizze>()
                .HasMany(e => e.CarelloTab)
                .WithRequired(e => e.ListaPizze)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UtentiTab>()
                .HasMany(e => e.CarelloTab)
                .WithRequired(e => e.UtentiTab)
                .WillCascadeOnDelete(false);
        }
    }
}
