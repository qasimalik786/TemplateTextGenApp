using TemplateTextGenApp.Domain;
using TemplatorText.Application;
using TemplatorText.Infrastructure;

DataModel dataModel = new
()
{
    Name = "John Doe",
    Address = new Address
    {
        City = "Budapest",
        Line1 = "Main Street, 1"
    }
};
string template = "Hello {Name},\n\nWe will be glad to see you in our office in {Address.City} at {Address.Line1}.\n\nLooking forward to meeting with you!\n\nBest, Our company.";

TemplateProcessor<DataModel> templateProcessor = new
();

TemplateTextService templateService = new
(templateProcessor);

string generatedText = templateService.GenTextFromTemplate(template, dataModel);
Console.WriteLine(generatedText);