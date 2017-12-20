namespace direction_appli
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.credits")]
    public partial class credits
    {
        [Key]
        [Column(Order = 0)]
        public DateTime dateCredits { get; set; }

        public decimal? credit { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
