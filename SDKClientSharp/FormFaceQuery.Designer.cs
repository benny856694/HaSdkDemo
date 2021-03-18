
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFaceQueryResult = new System.Windows.Forms.DataGridView();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPageIndicator = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaceQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePickerValidFromRangeEnd
            // 
            this.dateTimePickerValidFromRangeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerValidFromRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidFromRangeEnd.Location = new System.Drawing.Point(384, 76);
            this.dateTimePickerValidFromRangeEnd.Name = "dateTimePickerValidFromRangeEnd";
            this.dateTimePickerValidFromRangeEnd.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerValidFromRangeEnd.TabIndex = 77;
            // 
            // dateTimePickerValidStartRangeFrom
            // 
            this.dateTimePickerValidFromRangeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerValidFromRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidFromRangeStart.Location = new System.Drawing.Point(200, 76);
            this.dateTimePickerValidFromRangeStart.Name = "dateTimePickerValidStartRangeFrom";
            this.dateTimePickerValidFromRangeStart.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerValidFromRangeStart.TabIndex = 76;
            // 
            // checkBoxValidFrom
            // 
            this.checkBoxValidFrom.AutoSize = true;
            this.checkBoxValidFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxValidFrom.Location = new System.Drawing.Point(40, 78);
            this.checkBoxValidFrom.Name = "checkBoxValidFrom";
            this.checkBoxValidFrom.Size = new System.Drawing.Size(122, 17);
            this.checkBoxValidFrom.TabIndex = 75;
            this.checkBoxValidFrom.Text = "有效起始时间查询";
            this.checkBoxValidFrom.UseVisualStyleBackColor = true;
            // 
            // comboBoxQueryMode
            // 
            this.comboBoxQueryMode.FormattingEnabled = true;
            this.comboBoxQueryMode.Items.AddRange(new object[] {
            "精确查询",
            "模糊查询"});
            this.comboBoxQueryMode.Location = new System.Drawing.Point(861, 35);
            this.comboBoxQueryMode.Name = "comboBoxQueryMode";
            this.comboBoxQueryMode.Size = new System.Drawing.Size(100, 21);
            this.comboBoxQueryMode.TabIndex = 74;
            // 
            // dateTimePickerValidToRangeEnd
            // 
            this.dateTimePickerValidToRangeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerValidToRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidToRangeEnd.Location = new System.Drawing.Point(384, 109);
            this.dateTimePickerValidToRangeEnd.Name = "dateTimePickerValidToRangeEnd";
            this.dateTimePickerValidToRangeEnd.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerValidToRangeEnd.TabIndex = 73;
            // 
            // dateTimePickerValidToRangeStart
            // 
            this.dateTimePickerValidToRangeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerValidToRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidToRangeStart.Location = new System.Drawing.Point(200, 109);
            this.dateTimePickerValidToRangeStart.Name = "dateTimePickerValidToRangeStart";
            this.dateTimePickerValidToRangeStart.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerValidToRangeStart.TabIndex = 72;
            // 
            // checkBoxValidTo
            // 
            this.checkBoxValidTo.AutoSize = true;
            this.checkBoxValidTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxValidTo.Location = new System.Drawing.Point(40, 111);
            this.checkBoxValidTo.Name = "checkBoxValidTo";
            this.checkBoxValidTo.Size = new System.Drawing.Size(122, 17);
            this.checkBoxValidTo.TabIndex = 71;
            this.checkBoxValidTo.Text = "有效截止时间查询";
            this.checkBoxValidTo.UseVisualStyleBackColor = true;
            // 
            // textBoxWiegandNo
            // 
            this.textBoxWiegandNo.Location = new System.Drawing.Point(639, 35);
            this.textBoxWiegandNo.Name = "textBoxWiegandNo";
            this.textBoxWiegandNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiegandNo.TabIndex = 70;
            // 
            // checkBoxWiegandNo
            // 
            this.checkBoxWiegandNo.AutoSize = true;
            this.checkBoxWiegandNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxWiegandNo.Location = new System.Drawing.Point(571, 37);
            this.checkBoxWiegandNo.Name = "checkBoxWiegandNo";
            this.checkBoxWiegandNo.Size = new System.Drawing.Size(62, 17);
            this.checkBoxWiegandNo.TabIndex = 69;
            this.checkBoxWiegandNo.Text = "伟根号";
            this.checkBoxWiegandNo.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(435, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(106, 20);
            this.textBoxName.TabIndex = 68;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxName.Location = new System.Drawing.Point(384, 37);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(50, 17);
            this.checkBoxName.TabIndex = 67;
            this.checkBoxName.Text = "姓名";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(233, 35);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(131, 20);
            this.textBoxId.TabIndex = 66;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxId.Location = new System.Drawing.Point(200, 37);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(37, 17);
            this.checkBoxId.TabIndex = 65;
            this.checkBoxId.Text = "ID";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label69.Location = new System.Drawing.Point(1073, 49);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(0, 13);
            this.label69.TabIndex = 64;
            // 
            // buttonQuery
            // 
            this.buttonQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonQuery.Location = new System.Drawing.Point(998, 34);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(180, 25);
            this.buttonQuery.TabIndex = 62;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // checkBoxOutputFeature
            // 
            this.checkBoxOutputFeature.AutoSize = true;
            this.checkBoxOutputFeature.Checked = true;
            this.checkBoxOutputFeature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOutputFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxOutputFeature.Location = new System.Drawing.Point(861, 111);
            this.checkBoxOutputFeature.Name = "checkBoxOutputFeature";
            this.checkBoxOutputFeature.Size = new System.Drawing.Size(110, 17);
            this.checkBoxOutputFeature.TabIndex = 61;
            this.checkBoxOutputFeature.Text = "抓取特征值数据";
            this.checkBoxOutputFeature.UseVisualStyleBackColor = true;
            // 
            // textBoxPageSize
            // 
            this.textBoxPageSize.Location = new System.Drawing.Point(861, 76);
            this.textBoxPageSize.Name = "textBoxPageSize";
            this.textBoxPageSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxPageSize.TabIndex = 60;
            this.textBoxPageSize.Text = "19";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(800, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "页大小：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(37, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "角色：";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "普通人员",
            "白名单",
            "黑名单"});
            this.comboBoxType.Location = new System.Drawing.Point(82, 34);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(80, 21);
            this.comboBoxType.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(788, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "查询模式：";
            // 
            // dataGridViewFaceQueryResult
            // 
            this.dataGridViewFaceQueryResult.AllowUserToAddRows = false;
            this.dataGridViewFaceQueryResult.AllowUserToDeleteRows = false;
            this.dataGridViewFaceQueryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFaceQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaceQueryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnType});
            this.dataGridViewFaceQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFaceQueryResult.Location = new System.Drawing.Point(0, 157);
            this.dataGridViewFaceQueryResult.Name = "dataGridViewFaceQueryResult";
            this.dataGridViewFaceQueryResult.ReadOnly = true;
            this.dataGridViewFaceQueryResult.Size = new System.Drawing.Size(1190, 433);
            this.dataGridViewFaceQueryResult.TabIndex = 1;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(1114, 107);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(64, 23);
            this.buttonNextPage.TabIndex = 79;
            this.buttonNextPage.Text = "下一页>";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Location = new System.Drawing.Point(998, 107);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(61, 23);
            this.buttonPrevPage.TabIndex = 80;
            this.buttonPrevPage.Text = "<上一页";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // labelPageIndicator
            // 
            this.labelPageIndicator.AutoSize = true;
            this.labelPageIndicator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPageIndicator.Location = new System.Drawing.Point(1073, 112);
            this.labelPageIndicator.Name = "labelPageIndicator";
            this.labelPageIndicator.Size = new System.Drawing.Size(24, 13);
            this.labelPageIndicator.TabIndex = 81;
            this.labelPageIndicator.Text = "0/0";
            // 
            // FormFaceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 590);
            this.Controls.Add(this.dataGridViewFaceQueryResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFaceQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFaceQuery";
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
    }
}