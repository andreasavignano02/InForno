using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InForno
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<AmministratoriTab> AmministratoriTab { get; set; }
        public virtual DbSet<ListaPizze> ListaPizze { get; set; }
        public virtual DbSet<UtentiTab> UtentiTab { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListaPizze>()
                .Property(e => e.Prezzo)
                .HasPrecision(19, 4);
        }
    }
}
