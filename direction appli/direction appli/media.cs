namespace direction_appli
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bddppe.media")]
    public partial class media
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idMedia { get; set; }

        [Column(TypeName = "blob")]
        public byte[] photo { get; set; }

        [Column(TypeName = "blob")]
        public byte[] video { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string commentaires { get; set; }

        public int? idClient { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
