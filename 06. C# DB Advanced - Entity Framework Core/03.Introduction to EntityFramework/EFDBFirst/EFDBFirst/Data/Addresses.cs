using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDBFirst.Data
{
    public partial class Addresses
    {
        public Addresses()
        {
            Employees = new HashSet<Employees>();
        }

        public int AddressId { get; set; }
        public string AddressText { get; set; }
        public int? TownId { get; set; }

        //[ForeignKey(nameof(TownId))] //атрибут, TownId е идентификатор, описваме релацията, че пропартито Town (под него) е FK и използва TownId 
        public virtual Towns Town { get; set; } // FK - Navigation propertie
        public virtual ICollection<Employees> Employees { get; set; } // navigation propertie
    }
}
