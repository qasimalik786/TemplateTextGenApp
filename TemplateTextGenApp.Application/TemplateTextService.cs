using TemplateTextGenApp.Domain;
using TemplatorText.Infrastructure;

namespace TemplatorText.Application
{
    public class TemplateTextService
    {
        private readonly TemplateProcessor<DataModel> _templateProcessor;
        public TemplateTextService(TemplateProcessor<DataModel> templateProcessor)
        {
            _templateProcessor = templateProcessor;
        }

        public string GenTextFromTemplate(string template, DataModel dataModel)
        {
            _templateProcessor.SetType(dataModel);
            return _templateProcessor.TemplateToTextGenerator(template);
        }
    }
}