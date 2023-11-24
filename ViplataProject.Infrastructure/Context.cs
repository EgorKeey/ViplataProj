using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ViplataProject.Infrastructure
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<CompanyEntity> Companies { get; set; }
        public virtual DbSet<EmployeeEntity> Employees { get; set; }
        public virtual DbSet<JobEntity> Jobs { get; set; }
        public virtual DbSet<PaymentEntity> Payments { get; set; }
        public virtual DbSet<RoleEntity> Roles { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.Payment)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Job)
                .HasForeignKey(e => e.JobId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentEntity>()
                .Property(e => e.Vacation)
                .HasPrecision(53, 0);

            modelBuilder.Entity<PaymentEntity>()
                .Property(e => e.Bonus_For_Disability)
                .HasPrecision(53, 0);

            modelBuilder.Entity<PaymentEntity>()
                .Property(e => e.Bonus_For_Done_Work)
                .HasPrecision(53, 0);

            modelBuilder.Entity<RoleEntity>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
