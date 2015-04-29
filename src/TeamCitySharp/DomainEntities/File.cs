using System.Xml.Serialization;

namespace TeamCitySharp.DomainEntities
{
    public class File
    {
        [XmlElement(ElementName = "file")]
        public string FilePath { get; set; }
        [XmlElement(ElementName = "relative-file")]
        public string RelativeFile { get; set; }
    }
}