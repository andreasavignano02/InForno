namespace InForno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdineTab")]
    public partial class OrdineTab
    {
        [Key]
        public int IDOrdine { get; set; }

        public int? IdPizze { get; set; }

        public bool Evaso { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataOrdine { get; set; }

        public bool Confermato { get; set; }

        public virtual ListaPizze ListaPizze { get; set; }
    }
}
