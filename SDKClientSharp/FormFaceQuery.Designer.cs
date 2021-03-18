
namespace SDKClientSharp
{
    partial class FormFaceQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaceQuery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPageIndicator = new System.Windows.Forms.Label();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromRangeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerValidFromRangeStart = new System.Windows.Forms.DateTimePicker();
            this.checkBoxValidFrom = new System.Windows.Forms.CheckBox();
            this.comboBoxQueryMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerValidToRangeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerValidToRangeStart = new System.Windows.Forms.DateTimePicker();
            this.checkBoxValidTo = new System.Windows.Forms.CheckBox();
            this.textBoxWiegandNo = new System.Windows.Forms.TextBox();
            this.checkBoxWiegandNo = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.label69 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.checkBoxOutputFeature = new System.Windows.Forms.CheckBox();
            this.textBoxPageSize = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dataGridViewFaceQueryResult = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaceQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelPageIndicator);
            this.groupBox1.Controls.Add(this.buttonPrevPage);
            this.groupBox1.Controls.Add(this.buttonNextPage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerValidFromRangeEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerValidFromRangeStart);
            this.groupBox1.Controls.Add(this.checkBoxValidFrom);
            this.groupBox1.Controls.Add(this.comboBoxQueryMode);
            this.groupBox1.Controls.Add(this.dateTimePickerValidToRangeEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerValidToRangeStart);
            this.groupBox1.Controls.Add(this.checkBoxValidTo);
            this.groupBox1.Controls.Add(this.textBoxWiegandNo);
            this.groupBox1.Controls.Add(this.checkBoxWiegandNo);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.checkBoxName);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.checkBoxId);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.buttonQuery);
            this.groupBox1.Controls.Add(this.checkBoxOutputFeature);
            this.groupBox1.Controls.Add(this.textBoxPageSize);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Name = "label2";
            // 
            // labelPageIndicator
            // 
            resources.ApplyResources(this.labelPageIndicator, "labelPageIndicator");
            this.labelPageIndicator.Name = "labelPageIndicator";
            // 
            // buttonPrevPage
            // 
            resources.ApplyResources(this.buttonPrevPage, "buttonPrevPage");
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // buttonNextPage
            // 
            resources.ApplyResources(this.buttonNextPage, "buttonNextPage");
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimePickerValidFromRangeEnd
            // 
            resources.ApplyResources(this.dateTimePickerValidFromRangeEnd, "dateTimePickerValidFromRangeEnd");
            this.dateTimePickerValidFromRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidFromRangeEnd.Name = "dateTimePickerValidFromRangeEnd";
            // 
            // dateTimePickerValidFromRangeStart
            // 
            resources.ApplyResources(this.dateTimePickerValidFromRangeStart, "dateTimePickerValidFromRangeStart");
            this.dateTimePickerValidFromRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidFromRangeStart.Name = "dateTimePickerValidFromRangeStart";
            // 
            // checkBoxValidFrom
            // 
            resources.ApplyResources(this.checkBoxValidFrom, "checkBoxValidFrom");
            this.checkBoxValidFrom.Name = "checkBoxValidFrom";
            this.checkBoxValidFrom.UseVisualStyleBackColor = true;
            // 
            // comboBoxQueryMode
            // 
            resources.ApplyResources(this.comboBoxQueryMode, "comboBoxQueryMode");
            this.comboBoxQueryMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueryMode.FormattingEnabled = true;
            this.comboBoxQueryMode.Items.AddRange(new object[] {
            resources.GetString("comboBoxQueryMode.Items"),
            resources.GetString("comboBoxQueryMode.Items1")});
            this.comboBoxQueryMode.Name = "comboBoxQueryMode";
            // 
            // dateTimePickerValidToRangeEnd
            // 
            resources.ApplyResources(this.dateTimePickerValidToRangeEnd, "dateTimePickerValidToRangeEnd");
            this.dateTimePickerValidToRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidToRangeEnd.Name = "dateTimePickerValidToRangeEnd";
            // 
            // dateTimePickerValidToRangeStart
            // 
            resources.ApplyResources(this.dateTimePickerValidToRangeStart, "dateTimePickerValidToRangeStart");
            this.dateTimePickerValidToRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidToRangeStart.Name = "dateTimePickerValidToRangeStart";
            // 
            // checkBoxValidTo
            // 
            resources.ApplyResources(this.checkBoxValidTo, "checkBoxValidTo");
            this.checkBoxValidTo.Name = "checkBoxValidTo";
            this.checkBoxValidTo.UseVisualStyleBackColor = true;
            // 
            // textBoxWiegandNo
            // 
            resources.ApplyResources(this.textBoxWiegandNo, "textBoxWiegandNo");
            this.textBoxWiegandNo.Name = "textBoxWiegandNo";
            // 
            // checkBoxWiegandNo
            // 
            resources.ApplyResources(this.checkBoxWiegandNo, "checkBoxWiegandNo");
            this.checkBoxWiegandNo.Name = "checkBoxWiegandNo";
            this.checkBoxWiegandNo.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // checkBoxName
            // 
            resources.ApplyResources(this.checkBoxName, "checkBoxName");
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            resources.ApplyResources(this.textBoxId, "textBoxId");
            this.textBoxId.Name = "textBoxId";
            // 
            // checkBoxId
            // 
            resources.ApplyResources(this.checkBoxId, "checkBoxId");
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // label69
            // 
            resources.ApplyResources(this.label69, "label69");
            this.label69.Name = "label69";
            // 
            // buttonQuery
            // 
            resources.ApplyResources(this.buttonQuery, "buttonQuery");
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // checkBoxOutputFeature
            // 
            resources.ApplyResources(this.checkBoxOutputFeature, "checkBoxOutputFeature");
            this.checkBoxOutputFeature.Name = "checkBoxOutputFeature";
            this.checkBoxOutputFeature.UseVisualStyleBackColor = true;
            // 
            // textBoxPageSize
            // 
            resources.ApplyResources(this.textBoxPageSize, "textBoxPageSize");
            this.textBoxPageSize.Name = "textBoxPageSize";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // comboBoxType
            // 
            resources.ApplyResources(this.comboBoxType, "comboBoxType");
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            resources.GetString("comboBoxType.Items"),
            resources.GetString("comboBoxType.Items1"),
            resources.GetString("comboBoxType.Items2")});
            this.comboBoxType.Name = "comboBoxType";
            // 
            // dataGridViewFaceQueryResult
            // 
            resources.ApplyResources(this.dataGridViewFaceQueryResult, "dataGridViewFaceQueryResult");
            this.dataGridViewFaceQueryResult.AllowUserToAddRows = false;
            this.dataGridViewFaceQueryResult.AllowUserToDeleteRows = false;
            this.dataGridViewFaceQueryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFaceQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaceQueryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnType});
            this.dataGridViewFaceQueryResult.Name = "dataGridViewFaceQueryResult";
            this.dataGridViewFaceQueryResult.ReadOnly = true;
            // 
            // ColumnId
            // 
            resources.ApplyResources(this.ColumnId, "ColumnId");
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            resources.ApplyResources(this.ColumnName, "ColumnName");
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnType
            // 
            resources.ApplyResources(this.ColumnType, "ColumnType");
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // FormFaceQuery
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFaceQueryResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFaceQuery";
            this.Load += new System.EventHandler(this.FormFaceQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaceQueryResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromRangeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromRangeStart;
        private System.Windows.Forms.CheckBox checkBoxValidFrom;
        private System.Windows.Forms.ComboBox comboBoxQueryMode;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidToRangeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidToRangeStart;
        private System.Windows.Forms.CheckBox checkBoxValidTo;
        private System.Windows.Forms.TextBox textBoxWiegandNo;
        private System.Windows.Forms.CheckBox checkBoxWiegandNo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.CheckBox checkBoxOutputFeature;
        private System.Windows.Forms.TextBox textBoxPageSize;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFaceQueryResult;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.Label labelPageIndicator;
        private System.Windows.Forms.Label label2;
    }
}