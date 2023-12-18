namespace ViplataProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class CompanyEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyEntity()
        {
            Employee = new HashSet<EmployeeEntity>();
        }
        [Column(name:"Id")]
        public long ID { get; set; }
        [Column(name: "name company")]
        public long Name_Company { get; set; }

        [Column(name: "Physical_Address")]
        [Required]
        [StringLength(2147483647)]
        public string Physical_Address { get; set; }

        [Column(name: "Legal_Address")]
        [Required]
        [StringLength(2147483647)]
        public string Legal_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeEntity> Employee { get; set; }
    }
}
