using System.Runtime.Serialization;

namespace xmltextwriter
{
    public class Class1
    {
        public class Serializer<T>
        {
            public string Serialize(T obj)
            {
                var serializer = new DataContractSerializer(typeof(T));
                using (var writer = new StringWriter())
                using (var stm = new XmlTextWriter(writer))
                {
                    serializer.WriteObject(stm, obj);
                    return writer.ToString();
                }
            }

            public T Deserialize(string data)
            {
                var serializer = new DataContractSerializer(typeof(T));
                using (var reader = new StringReader(data))
                using (var stm = new XmlTextReader(reader))
                {
                    return (T)serializer.ReadObject(stm);
                }
            }
        }
    }
}