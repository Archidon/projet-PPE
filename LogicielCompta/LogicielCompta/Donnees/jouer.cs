namespace LogicielCompta.Donnees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.jouer")]
    public partial class jouer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPartie { get; set; }

        public decimal? paiement { get; set; }

        public virtual utilisateur utilisateur { get; set; }

        public virtual party party { get; set; }
    }
}
