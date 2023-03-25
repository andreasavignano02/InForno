namespace InForno.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdineTab")]
    public partial class OrdineTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdineTab()
        {
            ProdForOrderTab = new HashSet<ProdForOrderTab>();
        }

        [Key]
        public int IDOrdine { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataOrdine { get; set; }

        [Column(TypeName = "money")]
        public decimal? Totale { get; set; }

        [StringLength(50)]
        public string Indirizzo { get; set; }

        public string Note { get; set; }

        public bool? Delivered { get; set; }

        public virtual UtentiTab UtentiTab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdForOrderTab> ProdForOrderTab { get; set; }
    }
}
