namespace InForno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("ListaPizze")]
    public partial class ListaPizze
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListaPizze()
        {
            CarelloTab = new HashSet<CarelloTab>();
            OrdineTab = new HashSet<OrdineTab>();
        }

        [Key]
        public int IDPizze { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descrizione { get; set; }

        [Column(TypeName = "money")]
        public decimal Prezzo { get; set; }

        [Required]
        public string Foto { get; set; }
        [NotMapped()]
        public HttpPostedFileBase FileFoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarelloTab> CarelloTab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdineTab> OrdineTab { get; set; }
    }
}
