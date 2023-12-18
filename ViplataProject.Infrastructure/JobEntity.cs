namespace ViplataProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class JobEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobEntity()
        {
            Employee = new HashSet<EmployeeEntity>();
        }
        [Column(name: "ID")]
        public long ID { get; set; }

        [Column(name: "Title")]
        [Required]
        [StringLength(2147483647)]
        public string Title { get; set; }

        [Column(name: "Work_Day")]
        [StringLength(2147483647)]
        public string Work_Day { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeEntity> Employee { get; set; }
    }
}
