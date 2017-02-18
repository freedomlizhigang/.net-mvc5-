namespace w_test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Priv
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int MenuId { get; set; }

        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        [Required]
        [StringLength(100)]
        public string Label { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }
}
