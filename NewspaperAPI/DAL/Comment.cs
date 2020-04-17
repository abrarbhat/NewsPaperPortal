namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string commtype { get; set; }

        public int? dataid { get; set; }

        public int? answer { get; set; }

        public int? userid { get; set; }

        public string fullname { get; set; }

        public string nick { get; set; }

        public string email { get; set; }

        public int? hideemail { get; set; }

        public string title { get; set; }

        [Column("comment")]
        public string comment1 { get; set; }

        public int? positive { get; set; }

        public int? negative { get; set; }

        public string avatar { get; set; }

        public string date { get; set; }

        [StringLength(225)]
        public string ip { get; set; }

        public string deletdt { get; set; }

        public string deleter { get; set; }

        [StringLength(225)]
        public string updatedt { get; set; }

        [StringLength(225)]
        public string updaterip { get; set; }

        public int? statu { get; set; }
    }
}
