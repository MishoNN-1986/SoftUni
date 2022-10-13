using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDBFirst.Data2
{
    [Table("Addresses")] //////////
    public partial class Address
    {
        public Address()
        {
            Employees = new HashSet<Employees>();
        }

        [Key] // PK
        [Column("AddressID")]
        public int AddressId { get; set; }
        [Required]  // за да не е null string
        [StringLength(100)]
        public string AddressText { get; set; }
        [Column("TownID")]
        public int? TownId { get; set; }

        [ForeignKey("TownId")]
        [InverseProperty("Addresses")] // работи си без него
        public virtual Towns Town { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
