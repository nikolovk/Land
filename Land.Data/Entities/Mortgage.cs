namespace Land.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mortgage
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        [Key]
        [StringLength(50)]
        public string UPI { get; set; }

        public virtual LandProperty LandProperty { get; set; }
    }
}
