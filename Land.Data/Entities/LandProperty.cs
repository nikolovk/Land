namespace Land.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LandProperty
    {
        public LandProperty()
        {
            Owners = new HashSet<Owner>();
        }

        [Key]
        [StringLength(50)]
        public string UPI { get; set; }

        public double Area { get; set; }

        [StringLength(50)]
        public string Picture { get; set; }

        public virtual Mortgage Mortgage { get; set; }

        public virtual ICollection<Owner> Owners { get; set; }
    }
}
