namespace Project.Service
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VehicleDBContext : DbContext
    {
        public VehicleDBContext()
            : base("name=VehicleDBContext")
        {
        }

        public virtual DbSet<VehicleMake> VehicleMakes { get; set; }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleMake>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<VehicleMake>()
                .Property(e => e.Abrv)
                .IsFixedLength();

            modelBuilder.Entity<VehicleMake>()
                .HasMany(e => e.VehicleModels)
                .WithRequired(e => e.VehicleMake)
                .HasForeignKey(e => e.makeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleModel>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<VehicleModel>()
                .Property(e => e.Abrv)
                .IsFixedLength();
        }
    }
}
