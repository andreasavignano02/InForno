using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InForno.Controllers
{
    public partial class DBContext : DBContext
    {
        public DBContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<OrdineTab> OrdineTab { get; set; }
        public virtual DbSet<Prodotti> Prodotti { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UtentiTab> UtentiTab { get; set; }
        public virtual DbSet<ProdForOrderTab> ProdForOrderTab { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdineTab>()
                .Property(e => e.Totale)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrdineTab>()
                .HasMany(e => e.ProdForOrderTab)
                .WithOptional(e => e.OrdineTab)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Prodotti>()
                .Property(e => e.Prezzo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prodotti>()
                .HasMany(e => e.ProdForOrderTab)
                .WithOptional(e => e.Prodotti)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<UtentiTab>()
                .HasMany(e => e.OrdineTab)
                .WithOptional(e => e.UtentiTab)
                .HasForeignKey(e => e.UserId);
        }
    }
}
