namespace Persistence.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EyeeTrackDb : DbContext
    {
        public EyeeTrackDb()
            : base("name=EyeeTrackDb")
        {
        }

        public virtual DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Shop>()
                .Property(e => e.Address)
                .IsFixedLength();
        }
    }
}
