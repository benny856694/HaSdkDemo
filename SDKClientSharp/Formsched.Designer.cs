namespace SDKClientSharp
{
    partial class Formsched
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 569);
            this.tabControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formsched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Formsched";
            this.Text = "Formsched";
            this.Load += new System.EventHandler(this.Formsched_Load);
            this.ResumeLayout(false);

        }





        #endregion
        private System.Windows.Forms.TabControl tabControl1;
       
     
       
       
       
       
       
     
       
      
       
      
       

   
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.CheckBox[] chk_enable_group = new System.Windows.Forms.CheckBox[5]; //每个规则是否启用
        private System.Windows.Forms.CheckBox[,,] chk_enable_segment = new System.Windows.Forms.CheckBox[5,7,6]; //每个时间段是否启用

        private System.Windows.Forms.TextBox[] txt_no=new System.Windows.Forms.TextBox[5]; //模式编号
        private System.Windows.Forms.TextBox[] txt_name=new System.Windows.Forms.TextBox[5]; //模式名称

        private System.Windows.Forms.RadioButton[,] rb_mode = new System.Windows.Forms.RadioButton[5, 2];//每个规则的调度模式

        private System.Windows.Forms.TextBox[, ,] txt_hour_start = new System.Windows.Forms.TextBox[5,6,7]; //每个规则下每天每个时间段的起始时间的小时

        private System.Windows.Forms.TextBox[, ,] txt_minute_start = new System.Windows.Forms.TextBox[5, 6, 7]; //每个规则下每天每个时间段的起始时间的分钟

        private System.Windows.Forms.TextBox[, ,] txt_hour_end = new System.Windows.Forms.TextBox[5, 6, 7]; //每个规则下每天每个时间段的结束时间的小时

        private System.Windows.Forms.TextBox[, ,] txt_minute_end = new System.Windows.Forms.TextBox[5, 6, 7]; //每个规则下每天每个时间段的结束时间的分钟





    }
}