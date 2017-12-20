namespace LogicielCompta.Donnees
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Modele")
        {
        }

        public virtual DbSet<credit> credits { get; set; }
        public virtual DbSet<equipe> equipes { get; set; }
        public virtual DbSet<jouer> jouers { get; set; }
        public virtual DbSet<medium> media { get; set; }
        public virtual DbSet<notation> notations { get; set; }
        public virtual DbSet<party> parties { get; set; }
        public virtual DbSet<salle> salles { get; set; }
        public virtual DbSet<utilisateur> utilisateurs { get; set; }
        public virtual DbSet<ville> villes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<equipe>()
                .Property(e => e.nomEquipe)
                .IsUnicode(false);

            modelBuilder.Entity<equipe>()
                .HasMany(e => e.utilisateurs)
                .WithMany(e => e.equipes)
                .Map(m => m.ToTable("composer", "bddppe").MapLeftKey("idEquipe").MapRightKey("idClient"));

            modelBuilder.Entity<medium>()
                .Property(e => e.commentaires)
                .IsUnicode(false);

            modelBuilder.Entity<party>()
                .Property(e => e.typeObstacle)
                .IsUnicode(false);

            modelBuilder.Entity<party>()
                .Property(e => e.positionObstacle)
                .IsUnicode(false);

            modelBuilder.Entity<party>()
                .Property(e => e.typeElement)
                .IsUnicode(false);

            modelBuilder.Entity<party>()
                .Property(e => e.emplacementElement)
                .IsUnicode(false);

            modelBuilder.Entity<party>()
                .HasMany(e => e.jouers)
                .WithRequired(e => e.party)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<salle>()
                .Property(e => e.nomSalle)
                .IsUnicode(false);

            modelBuilder.Entity<salle>()
                .HasMany(e => e.notations)
                .WithRequired(e => e.salle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.mailClient)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.telClient)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.credits)
                .WithRequired(e => e.utilisateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.jouers)
                .WithRequired(e => e.utilisateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.notations)
                .WithRequired(e => e.utilisateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ville>()
                .Property(e => e.nomVille)
                .IsUnicode(false);
        }
    }
}
