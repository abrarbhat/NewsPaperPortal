namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(225)]
        public string fullname { get; set; }

        public string email { get; set; }

        public string pass { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birddy { get; set; }

        [StringLength(225)]
        public string from { get; set; }

        [StringLength(225)]
        public string lives { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? regdt { get; set; }

        public string regip { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? lastlog { get; set; }

        public string lastip { get; set; }

        public string type { get; set; }

        public int? statu { get; set; }

        public string per { get; set; }
    }
}
