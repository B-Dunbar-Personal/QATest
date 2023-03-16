using System.Xml.Linq;

namespace Question.Test.Interface
{
    public interface IReadXml
    {
        XDocument GetXml(string xmlName);
    }
}
