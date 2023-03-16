using System.Xml.Linq;

namespace Question.Test.Implementation
{
    public static class XmlHelper
    {
        public static object GetElementValue(XElement element, string elementName)
        {
            return element.Element(elementName).Value;
        }

        public static XElement CreateElement(string elementName, object value)
        {
            return new XElement(elementName, value);
        }

        public static IEnumerable<XElement> GetDescendants(XDocument xDocument, string descendants)
        {
            return xDocument.Descendants(descendants);
        }
    }
}
