<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609193/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1726)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Export to HTML - How to Export Only <BODY> Tag Content and Specify the Location of CSS Styles

This example illustrates how you can use the <strong>HtmlExporter</strong> class to export the document in HTML format. 

The **Export** method enables you to emit only content encompassed by the specified root tag. The **HtmlDocumentExporterOptions** object passed as the method's parameter specifies the location of CSS styles - they can be exported to an external file, located within the _style_ tag, or embedded as inline styles in the corresponding HTML tags.
The code uses a custom **UriProvider** to accomplish this task. The `IUriProviderService.RegisterProvider` method instantiates and registers the `UriProvider` service.

## Files to Review

* [Form1.cs](./CS/ExportOnlyBodyContent/Form1.cs) (VB: [Form1.vb](./VB/ExportOnlyBodyContent/Form1.vb))
* [MyUriProvider.cs](./CS/ExportOnlyBodyContent/MyUriProvider.cs) (VB: [MyUriProvider.vb](./VB/ExportOnlyBodyContent/MyUriProvider.vb))

## Documentation

* [Import an HTML File into the Rich Text Editor or Export a Document to HTML](https://docs.devexpress.com/WindowsForms/402852/controls-and-libraries/rich-text-editor/html-import-and-export)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-export-export-only-body-tag-content-and-specify-location-of-css-styles&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-export-export-only-body-tag-content-and-specify-location-of-css-styles&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
