using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w_test.Models
{
    [Table("yguser")]
    public class Yguser
    {
        [Key]
        public string usercode { get; set; }

        public string username { get; set; }

        public string userpass { get; set; }

        public string userpower { get; set; }

        public string groupid { get; set; }

        public string yflb { get; set; }

        public DateTime? lastdate { get; set; }
    }
}