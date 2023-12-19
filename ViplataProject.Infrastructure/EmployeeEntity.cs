namespace ViplataProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class EmployeeEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeEntity()
        {
            Payment = new HashSet<PaymentEntity>();
        }
        [Column("ID")]
        public long ID { get; set; }

        [Column("Second_Name")]
        [Required]
        [StringLength(2147483647)]
        public string Second_Name { get; set; }

        [Column("Name")]
        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [Column("Patronymic")]
        [Required]
        [StringLength(2147483647)]
        public string Patronymic { get; set; }

        [Column("Date_Of_Birth")]
        [Required]
        [StringLength(2147483647)]
        public string Date_Of_Birth { get; set; }

        [Column("Gender")]
        [Required]
        [StringLength(2147483647)]
        public string Gender { get; set; }

        [Column("disability")]
        [Required]
        [StringLength(2147483647)]
        public string disability { get; set; }

        [Column("expirience")]
        [Required]
        [StringLength(2147483647)]
        public string expirience { get; set; }
        [Column("ID_User")]
        public long UserId { get; set; }
        [Column("ID_Job")]
        public long JobId { get; set; }
        [Column("ID_Company")]
        public long CompanyId { get; set; }

        public virtual CompanyEntity Company { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual JobEntity Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentEntity> Payment { get; set; }
    }
}