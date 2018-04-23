namespace ExportOnlyBodyContent {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.grpXtraRichEdit = new DevExpress.XtraEditors.GroupControl();
            this.grpExportHtml = new DevExpress.XtraEditors.GroupControl();
            this.grpPlainHtml = new DevExpress.XtraEditors.GroupControl();
            this.btnLoadDocument = new DevExpress.XtraEditors.SimpleButton();
            this.edtCssStyleType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.edtExportHtmlType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnExportHtml = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpXtraRichEdit)).BeginInit();
            this.grpXtraRichEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpExportHtml)).BeginInit();
            this.grpExportHtml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPlainHtml)).BeginInit();
            this.grpPlainHtml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtCssStyleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtExportHtmlType.Properties)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(2, 22);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(438, 322);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.EmptyDocumentCreated += new System.EventHandler(this.richEditControl_EmptyDocumentCreated);
            this.richEditControl1.DocumentLoaded += new System.EventHandler(this.richEditControl_DocumentLoaded);
            // 
            // memoEdit2
            // 
            this.memoEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit2.Location = new System.Drawing.Point(2, 22);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(788, 145);
            this.memoEdit2.TabIndex = 2;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(2, 22);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(342, 322);
            this.memoEdit1.TabIndex = 3;
            // 
            // grpXtraRichEdit
            // 
            this.grpXtraRichEdit.Controls.Add(this.richEditControl1);
            this.grpXtraRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpXtraRichEdit.Location = new System.Drawing.Point(0, 0);
            this.grpXtraRichEdit.Name = "grpXtraRichEdit";
            this.grpXtraRichEdit.Size = new System.Drawing.Size(442, 346);
            this.grpXtraRichEdit.TabIndex = 0;
            this.grpXtraRichEdit.Text = "RichEditControl";
            // 
            // grpExportHtml
            // 
            this.grpExportHtml.Controls.Add(this.memoEdit2);
            this.grpExportHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpExportHtml.Location = new System.Drawing.Point(0, 0);
            this.grpExportHtml.Name = "grpExportHtml";
            this.grpExportHtml.Size = new System.Drawing.Size(792, 169);
            this.grpExportHtml.TabIndex = 0;
            this.grpExportHtml.Text = "Exported HTML";
            // 
            // grpPlainHtml
            // 
            this.grpPlainHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grpPlainHtml.Controls.Add(this.memoEdit1);
            this.grpPlainHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPlainHtml.Location = new System.Drawing.Point(0, 0);
            this.grpPlainHtml.Name = "grpPlainHtml";
            this.grpPlainHtml.Size = new System.Drawing.Size(346, 346);
            this.grpPlainHtml.TabIndex = 0;
            this.grpPlainHtml.Text = "Source HTML";
            // 
            // btnLoadDocument
            // 
            this.btnLoadDocument.Location = new System.Drawing.Point(9, 13);
            this.btnLoadDocument.Name = "btnLoadDocument";
            this.btnLoadDocument.Size = new System.Drawing.Size(90, 23);
            this.btnLoadDocument.TabIndex = 3;
            this.btnLoadDocument.Text = "Load Document";
            this.btnLoadDocument.Click += new System.EventHandler(this.OnLoadDocumentClick);
            // 
            // edtCssStyleType
            // 
            this.edtCssStyleType.Location = new System.Drawing.Point(467, 14);
            this.edtCssStyleType.Name = "edtCssStyleType";
            this.edtCssStyleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtCssStyleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.edtCssStyleType.Size = new System.Drawing.Size(163, 20);
            this.edtCssStyleType.TabIndex = 4;
            this.edtCssStyleType.SelectedValueChanged += new System.EventHandler(this.edtCssStyleType_SelectedValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(363, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "CssStyleExportType:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(115, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "ExportHtmlType:";
            // 
            // edtExportHtmlType
            // 
            this.edtExportHtmlType.Location = new System.Drawing.Point(199, 14);
            this.edtExportHtmlType.Name = "edtExportHtmlType";
            this.edtExportHtmlType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtExportHtmlType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.edtExportHtmlType.Size = new System.Drawing.Size(150, 20);
            this.edtExportHtmlType.TabIndex = 7;
            this.edtExportHtmlType.SelectedValueChanged += new System.EventHandler(this.edtExportHtmlType_SelectedValueChanged);
            // 
            // btnExportHtml
            // 
            this.btnExportHtml.Location = new System.Drawing.Point(648, 13);
            this.btnExportHtml.Name = "btnExportHtml";
            this.btnExportHtml.Size = new System.Drawing.Size(90, 23);
            this.btnExportHtml.TabIndex = 8;
            this.btnExportHtml.Text = "Export HTML";
            this.btnExportHtml.Click += new System.EventHandler(this.OnExportHtmlClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpXtraRichEdit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpPlainHtml);
            this.splitContainer1.Size = new System.Drawing.Size(792, 346);
            this.splitContainer1.SplitterDistance = 442;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 47);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpExportHtml);
            this.splitContainer2.Size = new System.Drawing.Size(792, 519);
            this.splitContainer2.SplitterDistance = 346;
            this.splitContainer2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadDocument);
            this.panel1.Controls.Add(this.btnExportHtml);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.edtCssStyleType);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.edtExportHtmlType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 47);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpXtraRichEdit)).EndInit();
            this.grpXtraRichEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpExportHtml)).EndInit();
            this.grpExportHtml.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpPlainHtml)).EndInit();
            this.grpPlainHtml.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtCssStyleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtExportHtmlType.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.GroupControl grpXtraRichEdit;
        private DevExpress.XtraEditors.GroupControl grpExportHtml;
        private DevExpress.XtraEditors.GroupControl grpPlainHtml;
        private DevExpress.XtraEditors.SimpleButton btnLoadDocument;
        private DevExpress.XtraEditors.ComboBoxEdit edtCssStyleType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit edtExportHtmlType;
        private DevExpress.XtraEditors.SimpleButton btnExportHtml;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
    }
}

