namespace KolokwiumPierwszy.Modules
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmploeeDbContext : DbContext
    {
        public EmploeeDbContext()
            : base("name=EmploeeDbContext")
        {
        }

        public virtual DbSet<DEPT> DEPT { get; set; }
        public virtual DbSet<EMP> EMP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPT>()
                .Property(e => e.DNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPT>()
                .Property(e => e.LOC)
                .IsUnicode(false);

            modelBuilder.Entity<DEPT>()
                .HasMany(e => e.EMP)
                .WithRequired(e => e.DEPT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.ENAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.JOB)
                .IsUnicode(false);
        }
    }
}
