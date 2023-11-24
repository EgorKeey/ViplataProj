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

        public virtual DbSet<CompanyEntity> Company { get; set; }
        public virtual DbSet<EmployeeEntity> Employee { get; set; }
        public virtual DbSet<JobEntity> Job { get; set; }
        public virtual DbSet<PaymentEntity> Payment { get; set; }
        public virtual DbSet<RoleEntity> Role { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.ID_Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.Payment)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ID_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Job)
                .HasForeignKey(e => e.ID_Job)
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
                .HasForeignKey(e => e.ID_Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ID_User)
                .WillCascadeOnDelete(false);
        }
    }
}
