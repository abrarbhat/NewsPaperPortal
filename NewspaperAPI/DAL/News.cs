namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string sefurl { get; set; }

        public string title { get; set; }

        public string summary { get; set; }

        [Column("news")]
        public string news1 { get; set; }

        public int? hits { get; set; }

        public int? comment { get; set; }

        public int? breakingnews { get; set; }

        public int? headline { get; set; }

        public int? newsorder { get; set; }

        public string tags { get; set; }

        public int? catid { get; set; }

        public string img { get; set; }

        public string breakingimg { get; set; }

        public string description { get; set; }

        public string date { get; set; }

        public string ip { get; set; }

        public string browser { get; set; }

        public string location { get; set; }

        public string timezone { get; set; }

        public int? statu { get; set; }

        public string who { get; set; }

        public string updatedt { get; set; }

        public string updaterip { get; set; }

        public string deldt { get; set; }

        public string whodeleted { get; set; }

        public string dtrip { get; set; }

        public int? deleted { get; set; }
    }
}
