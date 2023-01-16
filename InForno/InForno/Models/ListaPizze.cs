namespace InForno
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListaPizze")]
    public partial class ListaPizze
    {
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
    }
}
