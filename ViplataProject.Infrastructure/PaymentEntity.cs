namespace ViplataProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class PaymentEntity
    {
        [Column(name: "ID")]
        public long ID { get; set; }

        [Column(name: "ID_Employee")]
        public long ID_Employee { get; set; }

        [Column(name: "Rate")]
        [Required]
        [StringLength(2147483647)]
        public string Rate { get; set; }

        [Column(name: "Vacation")]
        public string Vacation { get; set; }

        [Column(name: "Bonus_For_Disability")]
        public decimal? Bonus_For_Disability { get; set; }

        [Column(name: "Bonus_For_Done_Work")]
        public decimal? Bonus_For_Done_Work { get; set; }
        public virtual EmployeeEntity Employee { get; set; }
    }
}