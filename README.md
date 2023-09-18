# Templator Text Generator

Custom text generator by template

## Requirements

1. Templates should contain plain text with placeholders which will be replaced with the real date from the data model.
2. The placeholder should contain the name (path) of the property from the model (also need to support nested properties like “Address.City”). The format of the placeholder is not determined so it can be any format. 
3. There is no need to support properties as collections (Lists, Arrays etc.) but you can if you want.
4. The relation between the template and the type of data model should be 1-to-1 (each template should have only one related data type and vice versa).
5. There should be a simple way to generate text from a template using a data model (there is no restriction - it could be an extension method or service with a really simple public call or whatever but the real logic should be encapsulated).
6. Unit tests are not required but really nice to have.
7. UI is not required.

## Project Architecture

Clean Code Architecture principles have been applied to develop the application.

## Folder Structure

├── TemplatorText
│   ├── TemplatorText.Application
│   │   ├── TemplateTextService.cs
│   │
│   ├── TemplatorText.Domain
│   │   └── Models
│   │       ├── DataModel.cs
│   │       └── Address.cs
│   │
│   ├── TemplatorText.Infrastructure
│   │   ├── TemplateEngine.cs
│   │ 
│   ├── TemplatorText.Presentation
│   │   └── Program.cs
│   │
│   ├── TemplatorText.UnitTest
│   │   └── TemplateProcessorTests.cs
│   │
│   └── TemplatorText.sln

