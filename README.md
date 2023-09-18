# Templator Text Generator

Custom text generator by template.

## Requirements

1. Templates should contain plain text with placeholders which will be replaced with the real date from the data model.
2. The placeholder should contain the name (path) of the property from the model (also need to support nested properties like “Address.City”). The format of the placeholder is not determined so it can be any format. 
3. There is no need to support properties as collections (Lists, Arrays etc.) but you can if you want.
4. The relation between the template and the type of data model should be 1-to-1 (each template should have only one related data type and vice versa).
5. There should be a simple way to generate text from a template using a data model (there is no restriction - it could be an extension method or service with a really simple public call or whatever but the real logic should be encapsulated).
6. Unit tests are not required but really nice to have.
7. UI is not required.

## Overview

1. **Define Data Model**

   Created classes 'DataModel' and 'Address' to represent structured data.

3. **TemplateService** 

    This class acts as a bridge between data and template processor.
   
4. **Process Templates**

   2.1 The 'TemplateProcessor' class is responsible for transforming templates into meaningful text.
   2.2 'TemplateToTextGenerator'. This method takes a template as an input and returns generated text as an output.

 5. **Implement App**
    
   'Program.cs' class, instantiate data model and templateService and templateProcessor, calling GenTextFromTemplate to process the template
## Project Architecture

Clean Code Architecture principles have been applied to develop the application.

## Folder Structure

![image](https://github.com/qasimalik786/TemplatorText/assets/93033428/aa8fa280-ed28-4162-8ee3-aab28a6ca36b)




