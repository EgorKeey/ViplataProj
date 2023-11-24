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
        public long ID { get; set; }

        public long EmployeeId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Rate { get; set; }

        public decimal Vacation { get; set; }

        public decimal? Bonus_For_Disability { get; set; }

        public decimal? Bonus_For_Done_Work { get; set; }

        public virtual EmployeeEntity Employee { get; set; }
    }
}
