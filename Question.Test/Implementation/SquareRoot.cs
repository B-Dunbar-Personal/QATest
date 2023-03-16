using System.Xml.Linq;
using Question.Test.Interface;

namespace Question.Test.Implementation
{
    public class SquareRoot : ISquareRoot
    {
        public int Value { get; set; }

        /// <summary>
        /// The purpose of this function is read the XML with schema the same as input.xml.
        /// It must read the Value from the XML.
        /// It must then calculate the square root using CalculateSquareRoot function and the approximate from the XML.
        /// A new node then needs to be inserted after the Approximate node called SquareRoot with the square root value.
        /// A new xDocument must be returned ie. the original xDocument parameter must not be overwritten.
        /// See output_example.xml.
        /// </summary>
        /// <param name="xDocument">The XML without inserted square roots.</param>
        /// <returns>The XML with inserted square roots. See output_example.xml as example output.</returns>
        public XDocument AddSquareRootToXml(XDocument xDocument)
        {
            throw new NotImplementedException(nameof(this.AddSquareRootToXml));
        }

        /// <summary>
        /// Iteration can be used to calculate the square root of a number using the following steps.
        /// Start with N the number whose square root is requested.
        /// Divide this by n an approximate root of N.
        /// Take the mean of the quotient and the approximate root.
        /// The formula would be ((n+N⁄n))⁄2.
	    /// The result of this becomes the new approximate value.
        /// Repeat step 2. If the quotient is equal to approximate value used, then you have found the square root.
        /// For example, to find the square root of 159.
        /// Divide 159 by 12 giving 13.25.
        /// Add 12 and 13.25 together and divide by 2 which is 12.625.
        /// Again divide 159 by 12.625 to get 12.59406.
        /// Add 12.625 and 12.59406 together and divide by 2 which is 12.60953.
        /// Repeat this process until same result is returned to get the square root.
        /// The final answer is 12.60952021.
        /// Complete the function below implementing the steps above to calculate the square root.
        /// The signature must not be changed.
        /// </summary>
        /// <param name="approximateValue">The decimal value to start with.</param>
        /// <returns>Square root value of Value property.</returns>
        public decimal CalculateSquareRoot(decimal approximateValue)
        {
            throw new NotImplementedException(nameof(this.CalculateSquareRoot));
        }
    }
}
