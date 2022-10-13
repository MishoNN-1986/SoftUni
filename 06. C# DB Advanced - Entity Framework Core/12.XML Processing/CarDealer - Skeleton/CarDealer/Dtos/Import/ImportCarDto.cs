using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dtos.Import
{
    [XmlType("Car")]
    public class ImportCarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("TraveledDistance")]
        public long TraveledDistance { get; set; }

        [XmlArray("parts")]
        public ImportPartIdDto[] PartsId { get; set; }
        //    <Car>
        //<make>Opel</make>
        //<model>Omega</model>
        //<TraveledDistance>176664996</TraveledDistance>
        //<parts>
    }
}
