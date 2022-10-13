using System;
using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace JsonLection
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person()
            //{
            //    FirstNane = "Stamo",
            //    LastName = "Petkov",
            //    Age = 42,
            //    Interests = new List<string>()
            //    {
            //        "programming",
            //        "hiking",
            //        "squash"
            //    }
            //};

            //Console.WriteLine(JsonHelper.SerializeObject(person));

            //----------------------------------------------------------------------------------------------

            //var person = JsonHelper.DeserializeObject<Person>(@"{ ""Age"":42,""FirstNane"":""Stamo"", ""Interests"":[""programming"",""hiking"", ""squash""],""LastName"":""Petkov""}");

            //Console.WriteLine(JsonHelper.SerializeObject(person));

            //===============================================================================================

            //using Newtonsoft.Json;
            //var person = JsonConvert.DeserializeObject<Person>(@"{ ""Age"":42,""FirstNane"":""Stamo"", ""Interests"":[""programming"",""hiking"", ""squash""],""LastName"":""Petkov""}");

            //Console.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));

            //----------------------------------------------------------------------------------------------------------

            //var template = new
            //{
            //    FirstName = string.Empty,
            //    LastName = string.Empty,
            //    Age = 0,
            //    Interests = new List<string>()
            //};

            //string json = @"{ ""Age"":42,""FirstNane"":""Stamo"", ""Interests"":[""programming"",""hiking"", ""squash""],""LastName"":""Petkov""}";
            //var person = JsonConvert.DeserializeAnonymousType(json, template);

            //Console.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));

            //-------------------------------------------------------------------------------------------------------

            //string json = @"{ ""person-age"":42,""FirstName"":""Stamo"", ""Interests"":[""programming"",""hiking"", ""squash""],""LastName"":""Petkov""}";
            //var person = JsonConvert.DeserializeObject<Person>(json);

            //Console.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));

            //-----------------------------------------------------------------------------------------------------------

            //var person = new Person()
            //{
            //    FirstName = "Stamo",
            //    LastName = "Petkov",
            //    Age = 42,
            //    Interests = new List<string>()
            //    {
            //        "programming",
            //        "hiking",
            //        "squash"
            //    }
            //};

            //var contractResolver = new DefaultContractResolver()
            //{
            //    NamingStrategy = new CamelCaseNamingStrategy()
            //};

            //Console.WriteLine(JsonConvert.SerializeObject(person, new JsonSerializerSettings()
            //{
            //    ContractResolver = contractResolver,
            //    Formatting = Formatting.Indented
            //}));

            //============================================================================

            //var products = JObject.Parse((@"{'products': [
            //                                                {'name': 'Fruits', 'products': ['apple', 'banana']},
            //                                                {'name': 'Vegetables', 'products': ['cucumber']}]}"));

            //Console.WriteLine(products["products"][0]["name"]);

            //==============================================================================

            string xml = @"<?xml version='1.0' standalone='no'?> 
 <root> 
    <person id='1'> 
        <name>Alan</name> 
        <url>www.google.com</url> 
    </person> 
    <person id='2'> 
        <name>Louis</name> 
        <url>www.yahoo.com</url> 
    </person> 
</root>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string jsonText = JsonConvert.SerializeXmlNode(doc,Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine(jsonText);
        }
    }
}
