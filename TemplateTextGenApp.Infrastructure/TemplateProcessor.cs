using System.Reflection;
using System.Text.RegularExpressions;

namespace TemplatorTextGenApp.Infrastructure
{
    public class TemplateProcessor<T>
    {
        private T? dataModel;

        public void SetType(T dataModel)
        {
            this.dataModel = dataModel;
        }

        public string TemplateToTextGenerator(string template)
        {
            string result = template;

            foreach (Match match in Regex.Matches(template, @"\{([^{}]+)\}").Cast<Match>())
            {
                string placeholder = match.Groups[1].Value.Trim();
                string[] propertyPath = placeholder.Split('.');
                object? currentModel = dataModel;
                foreach (string propertyName in propertyPath)
                {
                    PropertyInfo? property = currentModel?.GetType().GetProperty(propertyName);

                    if (property != null)
                    {
                        currentModel = property.GetValue(currentModel);
                    }
                    else
                    {
                        currentModel = null;
                        break;
                    }
                }
                result = result.Replace(match.Value, currentModel?.ToString() ?? string.Empty);
            }
            return result;
        }
    }
}