﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _01._HospitalDatabase.Data.Models
{
    public class Patient
    {
        public Patient()
        {
            this.Visitations = new HashSet<Visitation>();
            this.Diagnoses = new HashSet<Diagnose>();
            this.Prescriptions = new HashSet<PatientMedicament>();
        }

        //[Key]
        public int PatientId { get; set; }

        //[StringLength(50)]
        public string FirstName { get; set; }

        //[StringLength(50)]
        public string LastName { get; set; }

        //[StringLength(250)]
        public string Address { get; set; }

        //[StringLength(80)]
        public string Email { get; set; }

        public bool HasInsurance { get; set; }

        public ICollection<Visitation> Visitations { get; set; }

        public ICollection<Diagnose> Diagnoses { get; set; }

        public ICollection<PatientMedicament> Prescriptions { get; set; } // защото има клас many to many

    }
}
