namespace InForno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prodotti")]
    public partial class Prodotti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prodotti()
        {
            ProdForOrderTab = new HashSet<ProdForOrderTab>();
        }

        [Key]
        public int IDPizze { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [StringLength(20)]
        public string Foto { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prezzo { get; set; }

        public int? DeliveryTime { get; set; }

        [Required]
        public string Ingriedienti { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdForOrderTab> ProdForOrderTab { get; set; }
    }
}
