namespace Land.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Owner
    {
        public Owner()
        {
            LandProperties = new HashSet<LandProperty>();
        }

        [StringLength(50)]
        public string OwnerID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Picture { get; set; }

        public virtual ICollection<LandProperty> LandProperties { get; set; }
    }
}
