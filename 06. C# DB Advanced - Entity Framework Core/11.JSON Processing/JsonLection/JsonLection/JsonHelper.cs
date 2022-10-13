using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonLection
{
    public static class JsonHelper
    {

        public static string SerializeObject<T>(T obj)
        {
            var serializer = new DataContractJsonSerializer(obj.GetType());
            string result = String.Empty;

            using (var stream = new MemoryStream())
            {
                serializer.WriteObject(stream, obj);//записва обекта в stream
                result = Encoding.UTF8.GetString(stream.ToArray());
            }

            return result;
        }

        public static T DeserializeObject<T>(string json)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            var jsonBytes = Encoding.UTF8.GetBytes(json);
            T result = default(T);

            using (var stream = new MemoryStream(jsonBytes))
            {
                result = (T)serializer.ReadObject(stream);//чете от stream обекта
            }

            return result;
        }
    }
}
