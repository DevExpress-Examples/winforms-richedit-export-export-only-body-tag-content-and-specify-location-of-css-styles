Imports Microsoft.VisualBasic
Imports System
Namespace ExportOnlyBodyContent
    Public Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.memoEdit2 = New DevExpress.XtraEditors.MemoEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.grpXtraRichEdit = New DevExpress.XtraEditors.GroupControl()
            Me.grpExportHtml = New DevExpress.XtraEditors.GroupControl()
            Me.grpPlainHtml = New DevExpress.XtraEditors.GroupControl()
            Me.btnLoadDocument = New DevExpress.XtraEditors.SimpleButton()
            Me.edtCssStyleType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.edtExportHtmlType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.btnExportHtml = New DevExpress.XtraEditors.SimpleButton()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType(Me.memoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpXtraRichEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpXtraRichEdit.SuspendLayout()
            CType(Me.grpExportHtml, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpExportHtml.SuspendLayout()
            CType(Me.grpPlainHtml, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpPlainHtml.SuspendLayout()
            CType(Me.edtCssStyleType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtExportHtmlType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.splitContainer2.Panel1.SuspendLayout()
            Me.splitContainer2.Panel2.SuspendLayout()
            Me.splitContainer2.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(2, 22)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(438, 322)
            Me.richEditControl1.TabIndex = 0
'            Me.richEditControl1.EmptyDocumentCreated += New System.EventHandler(Me.richEditControl_EmptyDocumentCreated);
'            Me.richEditControl1.DocumentLoaded += New System.EventHandler(Me.richEditControl_DocumentLoaded);
            ' 
            ' memoEdit2
            ' 
            Me.memoEdit2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit2.Location = New System.Drawing.Point(2, 22)
            Me.memoEdit2.Name = "memoEdit2"
            Me.memoEdit2.Size = New System.Drawing.Size(788, 145)
            Me.memoEdit2.TabIndex = 2
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.Location = New System.Drawing.Point(2, 22)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(342, 322)
            Me.memoEdit1.TabIndex = 3
            ' 
            ' grpXtraRichEdit
            ' 
            Me.grpXtraRichEdit.Controls.Add(Me.richEditControl1)
            Me.grpXtraRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpXtraRichEdit.Location = New System.Drawing.Point(0, 0)
            Me.grpXtraRichEdit.Name = "grpXtraRichEdit"
            Me.grpXtraRichEdit.Size = New System.Drawing.Size(442, 346)
            Me.grpXtraRichEdit.TabIndex = 0
            Me.grpXtraRichEdit.Text = "RichEditControl"
            ' 
            ' grpExportHtml
            ' 
            Me.grpExportHtml.Controls.Add(Me.memoEdit2)
            Me.grpExportHtml.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpExportHtml.Location = New System.Drawing.Point(0, 0)
            Me.grpExportHtml.Name = "grpExportHtml"
            Me.grpExportHtml.Size = New System.Drawing.Size(792, 169)
            Me.grpExportHtml.TabIndex = 0
            Me.grpExportHtml.Text = "Exported HTML"
            ' 
            ' grpPlainHtml
            ' 
            Me.grpPlainHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.None
            Me.grpPlainHtml.Controls.Add(Me.memoEdit1)
            Me.grpPlainHtml.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpPlainHtml.Location = New System.Drawing.Point(0, 0)
            Me.grpPlainHtml.Name = "grpPlainHtml"
            Me.grpPlainHtml.Size = New System.Drawing.Size(346, 346)
            Me.grpPlainHtml.TabIndex = 0
            Me.grpPlainHtml.Text = "Source HTML"
            ' 
            ' btnLoadDocument
            ' 
            Me.btnLoadDocument.Location = New System.Drawing.Point(9, 13)
            Me.btnLoadDocument.Name = "btnLoadDocument"
            Me.btnLoadDocument.Size = New System.Drawing.Size(90, 23)
            Me.btnLoadDocument.TabIndex = 3
            Me.btnLoadDocument.Text = "Load Document"
'            Me.btnLoadDocument.Click += New System.EventHandler(Me.OnLoadDocumentClick);
            ' 
            ' edtCssStyleType
            ' 
            Me.edtCssStyleType.Location = New System.Drawing.Point(467, 14)
            Me.edtCssStyleType.Name = "edtCssStyleType"
            Me.edtCssStyleType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edtCssStyleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.edtCssStyleType.Size = New System.Drawing.Size(163, 20)
            Me.edtCssStyleType.TabIndex = 4
'            Me.edtCssStyleType.SelectedValueChanged += New System.EventHandler(Me.edtCssStyleType_SelectedValueChanged);
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(363, 17)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(101, 13)
            Me.labelControl1.TabIndex = 5
            Me.labelControl1.Text = "CssStyleExportType:"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(115, 18)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(81, 13)
            Me.labelControl2.TabIndex = 6
            Me.labelControl2.Text = "ExportHtmlType:"
            ' 
            ' edtExportHtmlType
            ' 
            Me.edtExportHtmlType.Location = New System.Drawing.Point(199, 14)
            Me.edtExportHtmlType.Name = "edtExportHtmlType"
            Me.edtExportHtmlType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edtExportHtmlType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.edtExportHtmlType.Size = New System.Drawing.Size(150, 20)
            Me.edtExportHtmlType.TabIndex = 7
'            Me.edtExportHtmlType.SelectedValueChanged += New System.EventHandler(Me.edtExportHtmlType_SelectedValueChanged);
            ' 
            ' btnExportHtml
            ' 
            Me.btnExportHtml.Location = New System.Drawing.Point(648, 13)
            Me.btnExportHtml.Name = "btnExportHtml"
            Me.btnExportHtml.Size = New System.Drawing.Size(90, 23)
            Me.btnExportHtml.TabIndex = 8
            Me.btnExportHtml.Text = "Export HTML"
'            Me.btnExportHtml.Click += New System.EventHandler(Me.OnExportHtmlClick);
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.grpXtraRichEdit)
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.grpPlainHtml)
            Me.splitContainer1.Size = New System.Drawing.Size(792, 346)
            Me.splitContainer1.SplitterDistance = 442
            Me.splitContainer1.TabIndex = 9
            ' 
            ' splitContainer2
            ' 
            Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer2.Location = New System.Drawing.Point(0, 47)
            Me.splitContainer2.Name = "splitContainer2"
            Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
            ' 
            ' splitContainer2.Panel1
            ' 
            Me.splitContainer2.Panel1.Controls.Add(Me.splitContainer1)
            ' 
            ' splitContainer2.Panel2
            ' 
            Me.splitContainer2.Panel2.Controls.Add(Me.grpExportHtml)
            Me.splitContainer2.Size = New System.Drawing.Size(792, 519)
            Me.splitContainer2.SplitterDistance = 346
            Me.splitContainer2.TabIndex = 10
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.btnLoadDocument)
            Me.panel1.Controls.Add(Me.btnExportHtml)
            Me.panel1.Controls.Add(Me.labelControl2)
            Me.panel1.Controls.Add(Me.edtCssStyleType)
            Me.panel1.Controls.Add(Me.labelControl1)
            Me.panel1.Controls.Add(Me.edtExportHtmlType)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(792, 47)
            Me.panel1.TabIndex = 11
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 566)
            Me.Controls.Add(Me.splitContainer2)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.memoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpXtraRichEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpXtraRichEdit.ResumeLayout(False)
            CType(Me.grpExportHtml, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpExportHtml.ResumeLayout(False)
            CType(Me.grpPlainHtml, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpPlainHtml.ResumeLayout(False)
            CType(Me.edtCssStyleType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtExportHtmlType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.ResumeLayout(False)
            Me.splitContainer2.Panel1.ResumeLayout(False)
            Me.splitContainer2.Panel2.ResumeLayout(False)
            Me.splitContainer2.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private memoEdit2 As DevExpress.XtraEditors.MemoEdit
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private grpXtraRichEdit As DevExpress.XtraEditors.GroupControl
        Private grpExportHtml As DevExpress.XtraEditors.GroupControl
        Private grpPlainHtml As DevExpress.XtraEditors.GroupControl
        Private WithEvents btnLoadDocument As DevExpress.XtraEditors.SimpleButton
        Private WithEvents edtCssStyleType As DevExpress.XtraEditors.ComboBoxEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private WithEvents edtExportHtmlType As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents btnExportHtml As DevExpress.XtraEditors.SimpleButton
        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private splitContainer2 As System.Windows.Forms.SplitContainer
        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace

