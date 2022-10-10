﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        public Room()
        {
            this.Patients = new List<Patient>();
        }

        public bool IsFull => this.Patients.Count >= 3;

        public List<Patient> Patients { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var patient in this.Patients.OrderBy(x => x.Name))
            {
                stringBuilder.AppendLine(patient.Name);
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
