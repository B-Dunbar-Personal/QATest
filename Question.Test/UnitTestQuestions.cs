using Question.Test.Implementation;
using Question.Test.Interface;
using System.Xml.Linq;

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
            services.AddTransient<IReadXml, ReadXml>();
            services.AddTransient<ISquareRoot, SquareRoot>();
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
            string xmlFileName = "input";
            var xmlService = _serviceProvider.GetService<IReadXml>();

            var squareRootService = _serviceProvider.GetService<ISquareRoot>();

            XDocument xml = xmlService.GetXml(xmlFileName);

            XDocument newXml = squareRootService.AddSquareRootToXml(xml);

            Assert.NotSame(xml, newXml);
            foreach (var descendants in XmlHelper.GetDescendants(newXml, XmlTags.Number))
            {
                var elements = descendants.Elements().ToList();

                Assert.True(elements.Count() == 3);
                Assert.Equal(elements[0].Name, XmlTags.Value);
                Assert.Equal(elements[1].Name, XmlTags.Approximate);
                Assert.Equal(elements[2].Name, XmlTags.SquareRoot);
                Assert.NotNull(elements[2].Value);
                Assert.NotEmpty(elements[2].Value);

            }
        }
    }
}