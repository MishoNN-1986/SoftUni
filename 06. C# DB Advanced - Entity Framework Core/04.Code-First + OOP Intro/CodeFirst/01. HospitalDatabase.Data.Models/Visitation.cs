﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _01._HospitalDatabase.Data.Models
{
    public class Visitation
    {
        //[Key]
        public int VisitationId { get; set; }

        public DateTime Date { get; set; }

       // [StringLength(250)]
        public string Comments { get; set; }

        //[ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }
        public int PatientId { get; set; }

        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
