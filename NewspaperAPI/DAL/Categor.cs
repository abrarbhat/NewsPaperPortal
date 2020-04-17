namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categor")]
    public partial class Categor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string sefurl { get; set; }

        public string catname { get; set; }

        public string catdetail { get; set; }

        public string catimg { get; set; }

        public int? upcatid { get; set; }

        public string cattype { get; set; }

        public int? statu { get; set; }

        public string createddt { get; set; }

        public string creator { get; set; }

        public string creatorip { get; set; }

        public string updateddt { get; set; }

        public string updaterip { get; set; }

        public string updater { get; set; }
    }
}
