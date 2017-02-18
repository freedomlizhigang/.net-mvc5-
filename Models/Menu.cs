namespace w_test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        [Required]
        [StringLength(100)]
        public string Label { get; set; }

        public int Sort { get; set; }

        public DateTime? Created_at { get; set; }

        public DateTime? Updated_at {
            get;
            set;
        }
    }
}
