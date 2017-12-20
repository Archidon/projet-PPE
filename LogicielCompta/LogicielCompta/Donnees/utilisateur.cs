namespace LogicielCompta.Donnees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.utilisateur")]
    public partial class utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilisateur()
        {
            credits = new HashSet<credit>();
            jouers = new HashSet<jouer>();
            media = new HashSet<medium>();
            notations = new HashSet<notation>();
            equipes = new HashSet<equipe>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        [StringLength(15)]
        public string nom { get; set; }

        [StringLength(20)]
        public string prenom { get; set; }

        [Column(TypeName = "blob")]
        public byte[] photo { get; set; }

        [StringLength(40)]
        public string adresse { get; set; }

        public DateTime? dateNaissance { get; set; }

        [StringLength(20)]
        public string mailClient { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string telClient { get; set; }

        public bool? mailConfirme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<credit> credits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jouer> jouers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medium> media { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notation> notations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipe> equipes { get; set; }
    }
}
