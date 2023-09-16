using TemplatorText.Infrastructure;

namespace TemplatorText.Application
{
    public class TemplateTextService<T>
    {
        private readonly TemplateProcessor<T> _templateProcessor;
        public TemplateTextService(TemplateProcessor<T> templateProcessor)
        {
            _templateProcessor = templateProcessor;
        }

        public string GenTextFromTemplate(string template, T dataModel)
        {
            _templateProcessor.SetType(dataModel);
            return _templateProcessor.TemplateToTextGenerator(template);
        }
    }
}