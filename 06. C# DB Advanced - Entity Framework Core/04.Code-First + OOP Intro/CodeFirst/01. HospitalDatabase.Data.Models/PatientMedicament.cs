using System;
using System.Collections.Generic;
using System.Text;

namespace _01._HospitalDatabase.Data.Models
{
    public class PatientMedicament
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int MedicamentId { get; set; }
        public Medicament Medicament { get; set; }

        //public ICollection<PatientMedicament> Prescriptions { get; set; }
    }
}
