namespace direction_appli
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bdd : DbContext
    {
        public bdd()
            : base("name=bdd")
        {
        }

        public virtual DbSet<credits> credits { get; set; }
        public virtual DbSet<equipe> equipe { get; set; }
        public virtual DbSet<jouer> jouer { get; set; }
        public virtual DbSet<media> media { get; set; }
        public virtual DbSet<notation> notation { get; set; }
        public virtual DbSet<parties> parties { get; set; }
        public virtual DbSet<salle> salle { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }
        public virtual DbSet<ville> ville { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<equipe>()
                .Property(e => e.nomEquipe)
                .IsUnicode(false);

            modelBuilder.Entity<equipe>()
                .HasMany(e => e.utilisateur)
                .WithMany(e => e.equipe)
                .Map(m => m.ToTable("composer", "bddppe").MapLeftKey("idEquipe").MapRightKey("idClient"));

            modelBuilder.Entity<media>()
                .Property(e => e.commentaires)
                .IsUnicode(false);

            modelBuilder.Entity<parties>()
                .Property(e => e.typeObstacle)
                .IsUnicode(false);

            modelBuilder.Entity<parties>()
                .Property(e => e.positionObstacle)
                .IsUnicode(false);

            modelBuilder.Entity<parties>()
                .Property(e => e.typeElement)
                .IsUnicode(false);

            modelBuilder.Entity<parties>()
                .Property(e => e.emplacementElement)
                .IsUnicode(false);

            modelBuilder.Entity<parties>()
                .HasMany(e => e.jouer)
                .WithRequired(e => e.parties)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<salle>()
                .Property(e => e.nomSalle)
                .IsUnicode(false);

            modelBuilder.Entity<salle>()
                .HasMany(e => e.notation)
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
                .HasMany(e => e.jouer)
                .WithRequired(e => e.utilisateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.notation)
                .WithRequired(e => e.utilisateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ville>()
                .Property(e => e.nomVille)
                .IsUnicode(false);
        }
    }
}
