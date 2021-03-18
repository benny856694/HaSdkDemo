
namespace SDKClientSharp
{
    partial class FormAddFace
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
            this.comboBoxScheduleMode = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.dateTimePickerValidFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerValidTo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxValidToType = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtwg_a = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxFaceType = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddFace = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxWiegandCardNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChoosePic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxScheduleMode
            // 
            this.comboBoxScheduleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScheduleMode.FormattingEnabled = true;
            this.comboBoxScheduleMode.Items.AddRange(new object[] {
            "不使用",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxScheduleMode.Location = new System.Drawing.Point(102, 167);
            this.comboBoxScheduleMode.Name = "comboBoxScheduleMode";
            this.comboBoxScheduleMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScheduleMode.TabIndex = 45;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label99.Location = new System.Drawing.Point(31, 170);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(55, 13);
            this.label99.TabIndex = 44;
            this.label99.Text = "调度模式";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label77.Location = new System.Drawing.Point(31, 214);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(55, 13);
            this.label77.TabIndex = 43;
            this.label77.Text = "起始时间";
            // 
            // dateTimePickerValidFrom
            // 
            this.dateTimePickerValidFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerValidFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidFrom.Location = new System.Drawing.Point(102, 212);
            this.dateTimePickerValidFrom.Name = "dateTimePickerValidFrom";
            this.dateTimePickerValidFrom.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerValidFrom.TabIndex = 42;
            // 
            // dateTimePickerValidTo
            // 
            this.dateTimePickerValidTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerValidTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidTo.Location = new System.Drawing.Point(102, 284);
            this.dateTimePickerValidTo.Name = "dateTimePickerValidTo";
            this.dateTimePickerValidTo.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerValidTo.TabIndex = 41;
            // 
            // comboBoxValidToType
            // 
            this.comboBoxValidToType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValidToType.FormattingEnabled = true;
            this.comboBoxValidToType.Items.AddRange(new object[] {
            "永不过期",
            "永久失效",
            "给定时间=>"});
            this.comboBoxValidToType.Location = new System.Drawing.Point(102, 246);
            this.comboBoxValidToType.Name = "comboBoxValidToType";
            this.comboBoxValidToType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxValidToType.TabIndex = 40;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(29, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "有效期止：";
            // 
            // txtwg_a
            // 
            this.txtwg_a.Location = new System.Drawing.Point(-102, 136);
            this.txtwg_a.Name = "txtwg_a";
            this.txtwg_a.Size = new System.Drawing.Size(100, 20);
            this.txtwg_a.TabIndex = 38;
            this.txtwg_a.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(-173, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 37;
            this.label26.Text = "韦根卡号：";
            // 
            // comboBoxFaceType
            // 
            this.comboBoxFaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaceType.FormattingEnabled = true;
            this.comboBoxFaceType.Items.AddRange(new object[] {
            "普通人员",
            "白名单",
            "黑名单"});
            this.comboBoxFaceType.Location = new System.Drawing.Point(102, 91);
            this.comboBoxFaceType.Name = "comboBoxFaceType";
            this.comboBoxFaceType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFaceType.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(263, 200);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(157, 67);
            this.textBox5.TabIndex = 35;
            this.textBox5.Text = "双击以选取图片，请保持图片中只有一张人脸，人脸宽高需大于100像素，正面，清晰";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(260, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "模板图片：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-102, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(-173, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "人员编号：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(31, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "人员姓名：";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(102, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "人员编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "类型：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddFace
            // 
            this.buttonAddFace.Location = new System.Drawing.Point(270, 318);
            this.buttonAddFace.Name = "buttonAddFace";
            this.buttonAddFace.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFace.TabIndex = 50;
            this.buttonAddFace.Text = "添加";
            this.buttonAddFace.UseVisualStyleBackColor = true;
            this.buttonAddFace.Click += new System.EventHandler(this.buttonAddFace_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "完成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxWiegandCardNo
            // 
            this.textBoxWiegandCardNo.Location = new System.Drawing.Point(102, 128);
            this.textBoxWiegandCardNo.Name = "textBoxWiegandCardNo";
            this.textBoxWiegandCardNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxWiegandCardNo.TabIndex = 53;
            this.textBoxWiegandCardNo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "韦根卡号：";
            // 
            // buttonChoosePic
            // 
            this.buttonChoosePic.Location = new System.Drawing.Point(333, 15);
            this.buttonChoosePic.Name = "buttonChoosePic";
            this.buttonChoosePic.Size = new System.Drawing.Size(87, 23);
            this.buttonChoosePic.TabIndex = 54;
            this.buttonChoosePic.Text = "选择图片";
            this.buttonChoosePic.UseVisualStyleBackColor = true;
            this.buttonChoosePic.Click += new System.EventHandler(this.buttonChoosePic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "所有图片格式|*.jpg;*.png;*.bmp";
            // 
            // FormAddFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 353);
            this.Controls.Add(this.buttonChoosePic);
            this.Controls.Add(this.textBoxWiegandCardNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddFace);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxScheduleMode);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.dateTimePickerValidFrom);
            this.Controls.Add(this.dateTimePickerValidTo);
            this.Controls.Add(this.comboBoxValidToType);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtwg_a);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.comboBoxFaceType);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddFace";
            this.Load += new System.EventHandler(this.FormAddFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxScheduleMode;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidTo;
        private System.Windows.Forms.ComboBox comboBoxValidToType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtwg_a;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxFaceType;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddFace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxWiegandCardNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChoosePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}