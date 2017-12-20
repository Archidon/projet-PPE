namespace LogicielCompta.Donnees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.parties")]
    public partial class party
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public party()
        {
            jouers = new HashSet<jouer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPartie { get; set; }

        public DateTime? dateHeurePartie { get; set; }

        public int? nombresEchecs { get; set; }

        public int? nbJoueur { get; set; }

        public int? nbObstacles { get; set; }

        [StringLength(10)]
        public string typeObstacle { get; set; }

        [StringLength(15)]
        public string positionObstacle { get; set; }

        public int? nbElement { get; set; }

        [StringLength(10)]
        public string typeElement { get; set; }

        [StringLength(15)]
        public string emplacementElement { get; set; }

        public int? idSalle { get; set; }

        public int? idEquipe { get; set; }

        public virtual equipe equipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jouer> jouers { get; set; }

        public virtual salle salle { get; set; }
    }
}
