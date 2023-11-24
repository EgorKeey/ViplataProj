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

        public long ID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Second_Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Date_Of_Birth { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Gender { get; set; }

        [StringLength(2147483647)]
        public string disability { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string expirience { get; set; }

        public long UserId { get; set; }

        public long JobId { get; set; }

        public long CompanyId { get; set; }

        public virtual CompanyEntity Company { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual JobEntity Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentEntity> Payment { get; set; }
    }
}
