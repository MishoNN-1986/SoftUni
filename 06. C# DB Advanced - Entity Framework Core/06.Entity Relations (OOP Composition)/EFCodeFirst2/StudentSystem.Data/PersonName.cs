using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Data
{
    public class PersonName // без Id
    {
        public PersonName(string firstName, string lastName)
        {
            if(firstName.Length + lastName.Length > 99)
            {
                throw new ArgumentException("Name must be not longer than 100 symbols");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
        }

        [Column("FirstName")]
        [Required]
        public string FirstName { get;private set; }

        [Column("LastName")]
        [Required]
        public string LastName { get;private set; }

        [NotMapped] //за да го няма в базата данни
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
