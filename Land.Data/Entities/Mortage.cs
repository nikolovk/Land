namespace Land.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mortage
    {
        public Mortage()
        {
            LandProperties = new HashSet<LandProperty>();
        }

        public int MortageID { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public virtual ICollection<LandProperty> LandProperties { get; set; }
    }
}
