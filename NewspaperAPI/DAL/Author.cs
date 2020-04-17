namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string img { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string email { get; set; }

        public string pass { get; set; }

        public string birthday { get; set; }

        public string from { get; set; }

        public string lives { get; set; }

        public string sex { get; set; }

        public int? statu { get; set; }

        public int? hit { get; set; }

        public int? type { get; set; }

        public string regdt { get; set; }

        public string regip { get; set; }

        public string reglog { get; set; }

        public string updatedt { get; set; }

        public string updater { get; set; }

        public string updaterip { get; set; }
    }
}
