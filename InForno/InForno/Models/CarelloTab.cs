namespace InForno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarelloTab")]
    public partial class CarelloTab
    {
        [Key]
        public int IDDettaglioOrdine { get; set; }

        public int IdPizze { get; set; }

        public int idUtente { get; set; }

        [Column(TypeName = "money")]
        public decimal PrezzoTotale { get; set; }

        public virtual ListaPizze ListaPizze { get; set; }

        public virtual UtentiTab UtentiTab { get; set; }
    }
}
