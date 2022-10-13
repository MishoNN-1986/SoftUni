using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Dtos.Import
{
    [XmlType("User")] // имаме обект User, с 3 пропартита, както е в xml
    public class ImportUserDto
    {
        [XmlElement("firstName")] //иначе няма да се мапне
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("age")]
        public int Age { get; set; }
        //<User>
        //<firstName>Chrissy</firstName>
        //<lastName>Falconbridge</lastName>
        //<age>50</age>
        //</User>
    }
}
