namespace NewspaperAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string nick { get; set; }

        public string email { get; set; }

        public string pass { get; set; }

        public int? forgot { get; set; }

        public string forgotpass { get; set; }

        public string forgotpassdt { get; set; }

        public string forgotpassip { get; set; }

        public string passeddt { get; set; }

        public string passedip { get; set; }

        public string dt { get; set; }

        public string dy { get; set; }

        public int? statu { get; set; }

        public int? sex { get; set; }

        public string acctype { get; set; }

        public int? acstatu { get; set; }

        public string regdate { get; set; }

        public string registerip { get; set; }

        public string regkey { get; set; }

        public string activationdt { get; set; }

        public string activatorip { get; set; }

        public int? regkeystatu { get; set; }

        public string lastlogindt { get; set; }

        public string lastip { get; set; }
    }
}
