namespace TVShowWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Torrent")]
    public partial class Torrent
    {
        [Key]
        [StringLength(100)]
        public string IdEpisode { get; set; }

        [StringLength(100)]
        public string Rozmiar { get; set; }

        [StringLength(100)]
        public string Format { get; set; }

        [StringLength(100)]
        public string Seed { get; set; }

        [StringLength(100)]
        public string Peer { get; set; }

        [StringLength(800)]
        public string Magnet { get; set; }

        [StringLength(200)]
        public string Nazwa { get; set; }
    }
}
