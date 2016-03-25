namespace TVShowWEB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TVEntity : DbContext
    {
        public TVEntity()
            : base("name=TVEntity")
        {
        }

        public virtual DbSet<Show> Show { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Torrent> Torrent { get; set; }
        public virtual DbSet<Episode> Episode { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.Rate)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.Votes)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.Poster)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.Cat)
                .IsFixedLength();

            modelBuilder.Entity<Show>()
                .Property(e => e.ActualSeasone)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.IdEpisode)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.Rozmiar)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.Format)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.Seed)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.Peer)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.Magnet)
                .IsFixedLength();

            modelBuilder.Entity<Torrent>()
                .Property(e => e.Nazwa)
                .IsFixedLength();

            modelBuilder.Entity<Episode>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<Episode>()
                .Property(e => e.EpisodesTitle)
                .IsFixedLength();

            modelBuilder.Entity<Episode>()
                .Property(e => e.EpisodesDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Episode>()
                .Property(e => e.EpisodesAir)
                .IsFixedLength();

            modelBuilder.Entity<Episode>()
                .Property(e => e.EpisodesCover)
                .IsFixedLength();

            modelBuilder.Entity<Episode>()
                .Property(e => e.IdEpisode)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.ShowID)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.EpisodeID)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Watched)
                .IsFixedLength();
        }
    }
}
