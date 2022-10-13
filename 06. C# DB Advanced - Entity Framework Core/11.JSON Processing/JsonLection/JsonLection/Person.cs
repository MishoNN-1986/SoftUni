using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace JsonLection
{
    //[DataContract] // за да покажем, че даден клас ще бъде използван за сереализация на данни( чрез [DataMember], останалите ги игнорира)
    public class Person
    {
        //[JsonProperty(PropertyName = "firstName", Order = 5, Required = Required.Always)]//[JsonProperty("firstName")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[JsonProperty("person-age")]
        public int Age { get; set; }

        //[JsonIgnore]
        public List<string> Interests { get; set; }
    }
}
