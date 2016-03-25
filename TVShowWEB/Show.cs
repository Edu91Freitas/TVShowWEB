namespace TVShowWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Show")]
    public partial class Show
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(800)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Rate { get; set; }

        [StringLength(100)]
        public string Votes { get; set; }

        [StringLength(500)]
        public string Poster { get; set; }

        [StringLength(300)]
        public string Cat { get; set; }

        [StringLength(10)]
        public string ActualSeasone { get; set; }
    }
}
