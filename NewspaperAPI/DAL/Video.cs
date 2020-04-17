namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Video")]
    public partial class Video
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string poster { get; set; }

        public string url { get; set; }

        public string type { get; set; }

        public int? catid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date { get; set; }

        public int? hit { get; set; }

        public int? like { get; set; }

        public int? dislike { get; set; }

        public string who { get; set; }

        public string ip { get; set; }

        public string updatedt { get; set; }

        public string updaterip { get; set; }

        public string tags { get; set; }

        public int? newsid { get; set; }

        public int? statu { get; set; }
    }
}
