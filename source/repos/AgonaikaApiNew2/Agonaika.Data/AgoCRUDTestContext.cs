using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MediatR;
using Microsoft.EntityFrameworkCore.Design;
using System.Threading;
using System.Threading.Tasks;
using Agonaika.Domain.TimeCapture;

namespace Agonaika.Data
{
    public partial class AgoCRUDTestContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "TimeCapture";

        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Timesheet> Timesheet { get; set; }

        private readonly IMediator _mediator;

        public AgoCRUDTestContext(DbContextOptions options)
 : base(options)
        { }

        public AgoCRUDTestContext(DbContextOptions<AgoCRUDTestContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            System.Diagnostics.Debug.WriteLine("AgonaikaDbContext::ctor ->" + this.GetHashCode());

            //Database.EnsureCreated();
            //Database.Migrate();
        }


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

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
