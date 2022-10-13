using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDBFirst.Data2
{
    public partial class Towns
    {
        public Towns()
        {
            Addresses = new HashSet<Address>();
        }

        [Key]
        [Column("TownID")]
        public int TownId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("Town")]
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
