using TemplateTextGenApp.Domain;
using TemplatorText.Infrastructure;

namespace TemplatorText.UniTest
{
    [TestClass]
    public class TemplateProcessorTests
    {
        [TestMethod]
        public void ValidTemplateAndModel_ReturnsExpectedResult()
        {
            // Arrange
            DataModel dataModel = new()
            {
                Name = "John Doe",
                Address = new Address
                {
                    City = "Budapest",
                    Line1 = "Main Street, 1"
                }
            };

            string template = "Hello {Name}, We will be glad to see you in our office in {Address.City} at {Address.Line1}.";
            TemplateProcessor<DataModel> templateProcessor = new();
            templateProcessor.SetType(dataModel);

            // Act
            string result = templateProcessor.TemplateToTextGenerator(template);

            // Assert
            string expected = "Hello John Doe, We will be glad to see you in our office in Budapest at Main Street, 1.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InValidTemplateAndModel_ReturnsExpectedResult()
        {
            // Arrange
            DataModel dataModel = new()
            {
                Name = "John Doe",
                Address = new Address
                {
                    City = "Budapest",
                    Line1 = "Main Street, 1"
                }
            };

            string template = "Hello {Name}, We will be glad to see you in our office in {Address.City} at {Address.Line1}.";
            TemplateProcessor<DataModel> templateProcessor = new();
            templateProcessor.SetType(dataModel);

            // Act
            string result = templateProcessor.TemplateToTextGenerator(template);

            // Assert
            string expected = "Hello Qasim, We will be glad to see you in our office in Budapest at Main Street, 1.";
            Assert.AreNotEqual(expected, result);
        }
    }
}