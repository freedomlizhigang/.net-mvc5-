namespace w_test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tsjlist")]
    public partial class tsjlist
    {
        [Key]
        public double aid { get; set; }

        public string blid { get; set; }

        public string mzid { get; set; }

        public string xm { get; set; }

        public string sex { get; set; }

        public DateTime? zwdate { get; set; }

        public string nl { get; set; }

        public string tel { get; set; }

        public string zdrq { get; set; }

        public string yg101 { get; set; }

        public string yg102 { get; set; }

        public string yg103 { get; set; }

        public string yg104 { get; set; }

        public string yg105 { get; set; }

        public string yg106 { get; set; }

        public string yg107 { get; set; }

        public string yg108 { get; set; }

        public string yg109 { get; set; }

        public string yg110 { get; set; }

        public string yg111 { get; set; }

        public string yg112 { get; set; }

        public string yg113 { get; set; }

        public string yg114 { get; set; }

        public string yg115 { get; set; }

        public string yg116 { get; set; }

        public string yg117 { get; set; }

        public string yg118 { get; set; }

        public string yg119 { get; set; }

        public string yg120 { get; set; }

        public string yg121 { get; set; }

        public string yg122 { get; set; }

        public string yg123 { get; set; }

        public string yg124 { get; set; }

        public string yg125 { get; set; }

        public string yg126 { get; set; }

        public string yg127 { get; set; }

        public string yg128 { get; set; }

        public string yg129 { get; set; }

        public string yg130 { get; set; }

        public double? flag { get; set; }
    }
}
