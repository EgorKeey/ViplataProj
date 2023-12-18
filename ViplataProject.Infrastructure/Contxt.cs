using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;

namespace ViplataProject.Infrastructure
{
    public partial class Contxt : DbContext
    {
        public virtual DbSet<CompanyEntity> Company { get; set; }
        public virtual DbSet<EmployeeEntity> Employee { get; set; }
        public virtual DbSet<JobEntity> Job { get; set; }
        public virtual DbSet<PaymentEntity> Payment { get; set; }
        public virtual DbSet<RoleEntity> Role { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }
        public Contxt(): base("Context")
        {}

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.Payment)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ID_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Job)
                .HasForeignKey(e => e.JobId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentEntity>()
                .Property(e => e.Vacation)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PaymentEntity>()
                .Property(e => e.Bonus_For_Disability)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PaymentEntity>()
                .Property(e => e.Bonus_For_Done_Work)
                .HasPrecision(18, 0);

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
