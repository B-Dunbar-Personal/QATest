using System.Xml.Linq;

namespace Question.Test.Interface
{
    public interface ISquareRoot
    {
        int Value { get; set; }

        decimal CalculateSquareRoot(decimal approximateValue);

        XDocument AddSquareRootToXml(XDocument xDocument);
    }
}
