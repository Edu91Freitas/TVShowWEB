namespace TVShowWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ShowID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string EpisodeID { get; set; }

        [StringLength(10)]
        public string Watched { get; set; }
    }
}
