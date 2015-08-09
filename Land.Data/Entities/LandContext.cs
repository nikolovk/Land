namespace Land.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LandContext : DbContext
    {
        public LandContext()
            : base("name=Land")
        {
        }

        public virtual DbSet<LandProperty> LandProperties { get; set; }
        public virtual DbSet<Mortage> Mortages { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LandProperty>()
                .HasMany(e => e.Owners)
                .WithMany(e => e.LandProperties)
                .Map(m => m.ToTable("LandPropertiesOwners").MapLeftKey("UPI").MapRightKey("OwnerID"));

            modelBuilder.Entity<Mortage>()
                .HasMany(e => e.LandProperties)
                .WithRequired(e => e.Mortage)
                .WillCascadeOnDelete(false);
        }
    }
}
