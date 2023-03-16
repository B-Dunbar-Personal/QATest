using System.Xml.Linq;
using Question.Test.Interface;

namespace Question.Test
{
    /// <summary>
    /// Tests the implementation.
    /// The tests are currently failing. 
    /// Make changes to the implementation so tests below pass.
    /// </summary>
    public class UnitTestQuestions
    {
        private readonly IServiceProvider _serviceProvider;

        public UnitTestQuestions()
        {
            ServiceCollection services = new();

            // add your services here.
            
            _serviceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// This tests that the square root of 159 is calculated correctly.
        /// </summary>
        [Fact]
        public void Test159SquareRoot()
        {
            var squareRootService = _serviceProvider.GetService<ISquareRoot>();

            squareRootService.Value = 159;

            decimal sq = squareRootService.CalculateSquareRoot(12);

            Assert.StrictEqual(Convert.ToDecimal(12.609520212918491531228625834), sq);
        }

        /// <summary>
        /// This tests that the square root of 1599 is calculated correctly.
        /// </summary>
        [Fact]
        public void Test1599SquareRoot()
        {
            var squareRootService = _serviceProvider.GetService<ISquareRoot>();

            squareRootService.Value = 1599;

            decimal sq = squareRootService.CalculateSquareRoot(12);

            Assert.StrictEqual(Convert.ToDecimal(39.9874980462644), sq);
        }

        /// <summary>
        /// This tests the AddSquareRootToXml function.
        /// The verification of the XML has been omitted from this test. Add your own verification for this.
        /// </summary>
        [Fact]
        public void TestCreateSquareRootXml()
        {
            var xmlService = _serviceProvider.GetService<IReadXml>();

            var squareRootService = _serviceProvider.GetService<ISquareRoot>();

            XDocument xml = xmlService.GetXml("input");

            XDocument newXml = squareRootService.AddSquareRootToXml(xml);
            
            // Write you own verification for the XML.
        }
    }
}