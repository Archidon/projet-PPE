namespace LogicielCompta.Donnees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.credits")]
    public partial class credit
    {
        [Key]
        [Column(Order = 0)]
        public DateTime dateCredits { get; set; }

        [Column("credit")]
        public decimal? credit1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
