namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Setting")]
    public partial class Setting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string sitename { get; set; }

        public string url { get; set; }

        public string title { get; set; }

        public string copy { get; set; }

        public string analytics { get; set; }

        public int? statu { get; set; }

        public string mail { get; set; }

        public string mailhost { get; set; }

        public string mailport { get; set; }

        public string mailuser { get; set; }

        public string mailpassword { get; set; }

        public string repmail { get; set; }

        public int? login { get; set; }

        public int? reg { get; set; }

        public int? regtype { get; set; }

        public int? advertbox { get; set; }

        [Column(" ice")]
        public int? C_ice { get; set; }

        public int? manset { get; set; }

        public int? manset2 { get; set; }

        public int? flas { get; set; }

        public int? updater { get; set; }

        public string updatedt { get; set; }

        public string updaterip { get; set; }
    }
}
