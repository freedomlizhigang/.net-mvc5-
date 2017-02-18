namespace w_test.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Sg2017 : DbContext
    {
        public Sg2017()
            : base("name=Sg2017")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Priv> Privs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRole"));
        }
    }
}
