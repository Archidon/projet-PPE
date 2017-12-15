namespace LogicielCompta.Donnees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.notation")]
    public partial class notation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSalle { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime dateHeure { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        public short? note { get; set; }

        public virtual salle salle { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
