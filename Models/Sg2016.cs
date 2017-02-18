namespace w_test.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Sg2016 : DbContext
    {
        public Sg2016()
            : base("name=Sg2016")
        {
        }

        public virtual DbSet<Sgnlist> Sgnlists { get; set; }
        public virtual DbSet<sgnlist01> sgnlist01 { get; set; }
        public virtual DbSet<tsjlist> tsjlists { get; set; }
        public virtual DbSet<yglist> yglists { get; set; }
        public virtual DbSet<Yguser> Ygusers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
