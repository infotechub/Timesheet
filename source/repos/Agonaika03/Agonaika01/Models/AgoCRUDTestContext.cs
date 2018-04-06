using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Agonaika01.Models
{
    public partial class AgoCRUDTestContext : DbContext
    {
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Timesheet> Timesheet { get; set; }

        public AgoCRUDTestContext(DbContextOptions<AgoCRUDTestContext> options)
 : base(options)
        { }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning 
                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AgoCRUDTest;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AffiliateId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsExempt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Position)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodEndDate).HasColumnType("datetime");
            });
        }
    }
}
