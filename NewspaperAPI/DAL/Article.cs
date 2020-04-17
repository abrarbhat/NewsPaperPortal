namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string sefurl { get; set; }

        public string title { get; set; }

        public string definition { get; set; }

        public string img { get; set; }

        public int? catid { get; set; }

        public int? authorid { get; set; }

        public string summary { get; set; }

        [Column("article")]
        public string article1 { get; set; }

        public string tags { get; set; }

        public int? allowcomm { get; set; }

        public int? voteup { get; set; }

        public int? votedown { get; set; }

        public int? statu { get; set; }

        public string insertdt { get; set; }

        public string ip { get; set; }

        public string log { get; set; }

        public string updatedt { get; set; }

        public string updaterip { get; set; }

        public string updatedlog { get; set; }
    }
}
