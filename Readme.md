<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609193/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1726)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ExportOnlyBodyContent/Form1.cs) (VB: [Form1.vb](./VB/ExportOnlyBodyContent/Form1.vb))
* [MyUriProvider.cs](./CS/ExportOnlyBodyContent/MyUriProvider.cs) (VB: [MyUriProvider.vb](./VB/ExportOnlyBodyContent/MyUriProvider.vb))
<!-- default file list end -->
# Export to HTML - How to export only <BODY> tag content and specify the location of CSS styles


<p>This example illustrates how you can use the <strong>HtmlExporter</strong> class to export the document in HTML format. The <strong>Export</strong> method enables you to emit only content encompassed by the specified root tag. The <strong>HtmlDocumentExporterOptions</strong> object passed as the method's parameter specifies the location of CSS styles - they can be exported to external file, located within the <i>style</i> tag or embedded as inline styles in the corresponding HTML tags.<br />
The code uses a custom <strong>UriProvider</strong> to accomplish this task. It is instantiated and registered via the <strong>RegisterProvider</strong> method of RichEditControl's <strong>IUriProviderService</strong><strong> </strong>service.<br />
<br />
</p>

<br/>


