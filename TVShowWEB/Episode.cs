namespace TVShowWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Episode")]
    public partial class Episode
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(200)]
        public string EpisodesTitle { get; set; }

        [StringLength(500)]
        public string EpisodesDescriptions { get; set; }

        [StringLength(200)]
        public string EpisodesAir { get; set; }

        [StringLength(200)]
        public string EpisodesCover { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IdEpisode { get; set; }
    }
}
