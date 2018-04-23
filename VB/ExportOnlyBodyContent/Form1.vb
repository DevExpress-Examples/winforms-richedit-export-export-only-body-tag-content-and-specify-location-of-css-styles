Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
#Region "#usings"
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.XtraRichEdit.Export.Html
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.Office.Services
#End Region ' #usings



Namespace ExportOnlyBodyContent
	Partial Public Class Form1
		Inherits XtraForm
		Private cssExportType As CssPropertiesExportType
		Private htmlExportType As ExportRootTag

		Public Sub New()
			InitializeComponent()
			InitComboHtmlExportType()
			InitComboCssExportType()

		End Sub
		#Region "Initializing"
		Private Sub InitComboHtmlExportType()
			Dim collExportHtml As ComboBoxItemCollection = edtExportHtmlType.Properties.Items
			collExportHtml.BeginUpdate()
			collExportHtml.Clear()
			collExportHtml.Add(ExportRootTag.Body)
			collExportHtml.Add(ExportRootTag.Html)
			collExportHtml.EndUpdate()
			edtExportHtmlType.SelectedIndex = 0
			htmlExportType = ExportRootTag.Body
		End Sub
		Private Sub InitComboCssExportType()
			Dim collCssStyle As ComboBoxItemCollection = edtCssStyleType.Properties.Items
			collCssStyle.BeginUpdate()
			collCssStyle.Clear()
			collCssStyle.Add(CssPropertiesExportType.Style)
			collCssStyle.Add(CssPropertiesExportType.Link)
			collCssStyle.Add(CssPropertiesExportType.Inline)
			collCssStyle.EndUpdate()
			edtCssStyleType.SelectedIndex = 0
			cssExportType = CssPropertiesExportType.Style
		End Sub
		Protected Friend Sub OnLoadDocumentClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadDocument.Click
			Me.richEditControl1.LoadDocument()
		End Sub
		Private Sub richEditControl_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.DocumentLoaded
			Try
				Dim fileName As String = richEditControl1.Options.DocumentSaveOptions.CurrentFileName
				If (Not String.IsNullOrEmpty(fileName)) Then
					Using reader As New StreamReader(fileName)
						Me.memoEdit1.Text = reader.ReadToEnd()
					End Using
				End If
			Catch
			End Try
		End Sub

		Private Sub richEditControl_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.EmptyDocumentCreated
			Me.memoEdit1.Text = String.Empty
		End Sub
#End Region ' Initializing

		#Region "Adjusting"
		Private Function GetFileName(ByVal filter As String) As String
			Using saveFileDialog As New SaveFileDialog()
				saveFileDialog.Filter = filter
				saveFileDialog.RestoreDirectory = True
				saveFileDialog.CheckFileExists = False
				saveFileDialog.CheckPathExists = True
				saveFileDialog.OverwritePrompt = True
				saveFileDialog.DereferenceLinks = True
				saveFileDialog.ValidateNames = True
				If saveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					Return saveFileDialog.FileName
				End If
			End Using
			Return String.Empty
		End Function
		Private Sub SaveFile(ByVal fileName As String, ByVal value As String)
			Using stream As New FileStream(fileName, FileMode.Create, FileAccess.Write)
				Using writer As New StreamWriter(stream)
					writer.Write(value)
				End Using
			End Using
		End Sub

		Private Sub edtExportHtmlType_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtExportHtmlType.SelectedValueChanged
			Me.htmlExportType = CType(edtExportHtmlType.EditValue, ExportRootTag)

		End Sub
		Private Sub edtCssStyleType_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtCssStyleType.SelectedValueChanged
			Me.cssExportType = CType(edtCssStyleType.EditValue, CssPropertiesExportType)
		End Sub
		#End Region

		Private Sub OnExportHtmlClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportHtml.Click
			Dim fileName As String = GetFileName("HyperText Markup Language Format|*.html")
			If String.IsNullOrEmpty(fileName) Then
				Return
			End If
			Dim svc As IUriProviderService = CType(richEditControl1.GetService(GetType(IUriProviderService)), IUriProviderService)
			svc.RegisterProvider(New MyUriProvider(Path.GetDirectoryName(fileName)))
			Dim stringHtml As String = String.Empty
			ExportHtml(stringHtml, Nothing, fileName)
			Me.memoEdit2.Text = stringHtml
			SaveFile(fileName, stringHtml)

		End Sub
		#Region "#exporting"
	Private Sub ExportHtml(<System.Runtime.InteropServices.Out()> ByRef stringHtml As String, ByVal exporter As HtmlExporter, ByVal fileName As String)
		stringHtml = String.Empty
		Dim options As New HtmlDocumentExporterOptions()
		options.ExportRootTag = htmlExportType
		options.CssPropertiesExportType = cssExportType
		options.TargetUri = Path.GetFileNameWithoutExtension(fileName)
		exporter = New HtmlExporter(Me.richEditControl1.Model, options)
		stringHtml = exporter.Export()
	End Sub
		#End Region ' #exporting
	End Class
End Namespace