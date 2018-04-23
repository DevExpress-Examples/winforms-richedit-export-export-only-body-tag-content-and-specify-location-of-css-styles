Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.Office.Services
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.Office.Utils


Namespace ExportOnlyBodyContent
	Public Class MyUriProvider
		Implements IUriProvider
		Private rootDirecory As String
		Public Sub New(ByVal rootDirectory As String)
			If String.IsNullOrEmpty(rootDirectory) Then
				Exceptions.ThrowArgumentException("rootDirectory", rootDirectory)
			End If
			Me.rootDirecory = rootDirectory
		End Sub

		Public Function CreateCssUri(ByVal rootUri As String, ByVal styleText As String, ByVal relativeUri As String) As String Implements  IUriProvider.CreateCssUri
			Dim cssDir As String = String.Format("{0}\{1}", Me.rootDirecory, rootUri.Trim("/"c))
			If (Not Directory.Exists(cssDir)) Then
				Directory.CreateDirectory(cssDir)
			End If
			Dim cssFileName As String = String.Format("{0}\style.css", cssDir)
			File.AppendAllText(cssFileName, styleText)
			Return GetRelativePath(cssFileName)
		End Function
		Public Function CreateImageUri(ByVal rootUri As String, ByVal image As OfficeImage, ByVal relativeUri As String) As String Implements  IUriProvider.CreateImageUri
			Dim imagesDir As String = String.Format("{0}\{1}", Me.rootDirecory, rootUri.Trim("/"c))
			If (Not Directory.Exists(imagesDir)) Then
				Directory.CreateDirectory(imagesDir)
			End If
			Dim imageName As String = String.Format("{0}\{1}.png", imagesDir, Guid.NewGuid())
			image.NativeImage.Save(imageName, ImageFormat.Png)
			Return GetRelativePath(imageName)
		End Function
		Private Function GetRelativePath(ByVal path As String) As String
			Dim substring As String = path.Substring(Me.rootDirecory.Length)
			Return substring.Replace("\", "/").Trim("/"c)
		End Function
	End Class
End Namespace
