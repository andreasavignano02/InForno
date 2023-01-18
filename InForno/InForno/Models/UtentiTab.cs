namespace InForno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UtentiTab")]
    public partial class UtentiTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UtentiTab()
        {
            CarelloTab = new HashSet<CarelloTab>();
        }

        [Key]
        public int IDUtente { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cognome { get; set; }

        [Required]
        public string Indirizzo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarelloTab> CarelloTab { get; set; }
    }
}
