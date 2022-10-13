﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.Data.Models
{
    public class Cell : BaseModel<int>
    {
        public Cell()
        {
            this.Prisoners = new List<Prisoner>();
        }

        [Range(1, 1000)]
        public int CellNumber { get; set; }

        public bool HasWindow { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Prisoner> Prisoners { get; set; }
    }
}
