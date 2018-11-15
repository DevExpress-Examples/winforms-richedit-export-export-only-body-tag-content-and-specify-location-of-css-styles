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


