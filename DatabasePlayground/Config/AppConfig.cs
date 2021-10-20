using System.Xml.Serialization;

namespace DatabasePlayground.Config
{
    [XmlRoot("Configuration")]
    public class AppConfig
    {
        [XmlElement("ConnectionString")]
        public string? ConnectionString { get; set; }
    }
}
