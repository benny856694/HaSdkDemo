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
            //this.tabPage1 = new System.Windows.Forms.TabPage();
            
         
          
          
           
         
           
           
           
         
        
          
           
          
          
           
           
           
           
            
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            //this.tabPage1.SuspendLayout();
            //this.tabControl2.SuspendLayout();
            //this.tabPage2.SuspendLayout();
           // this.panel2.SuspendLayout();
            //this.panel4.SuspendLayout();
            //this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.createEffectArea(0,"规则1"));
            this.tabControl1.Controls.Add(this.createEffectArea(1, "规则2"));
            this.tabControl1.Controls.Add(this.createEffectArea(2, "规则3"));
            this.tabControl1.Controls.Add(this.createEffectArea(3, "规则4"));
            this.tabControl1.Controls.Add(this.createEffectArea(4, "规则5"));
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 525);
            this.tabControl1.TabIndex = 0;
           
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formsched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Formsched";
            this.Text = "Formsched";
            this.tabControl1.ResumeLayout(false);
            //this.tabPage1.ResumeLayout(false);
            //this.tabControl2.ResumeLayout(false);
            //this.tabPage2.ResumeLayout(false);
            //this.panel2.ResumeLayout(false);
            //this.panel4.ResumeLayout(false);
            //this.panel4.PerformLayout();
           // this.panel1.ResumeLayout(false);
           // this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TabPage createEffectArea(int no, string gz)
        {
            System.Windows.Forms.TabPage tabPage1 = new System.Windows.Forms.TabPage();
            System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
            System.Windows.Forms.CheckBox checkbox1 = new System.Windows.Forms.CheckBox();
            System.Windows.Forms.TabControl tabControl2 = new System.Windows.Forms.TabControl();
            System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
            System.Windows.Forms.RadioButton radioButton2 = new System.Windows.Forms.RadioButton();
            System.Windows.Forms.RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
            System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            // 
            // tabPage1
            // 
           
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage" + no;
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(815, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = gz;
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(createEffectAreaElement(no,0,"周日"));
            tabControl2.Controls.Add(createEffectAreaElement(no, 1, "周一"));
            tabControl2.Controls.Add(createEffectAreaElement(no, 2, "周二"));
            tabControl2.Controls.Add(createEffectAreaElement(no, 3, "周三"));
            tabControl2.Controls.Add(createEffectAreaElement(no, 4, "周四"));
            tabControl2.Controls.Add(createEffectAreaElement(no, 5, "周五"));
            tabControl2.Controls.Add(createEffectAreaElement(no, 6, "周六"));

            tabControl2.Location = new System.Drawing.Point(6, 72);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(803, 424);
            tabControl2.TabIndex = 1;
          
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkbox1);
            panel1.Location = new System.Drawing.Point(3, 6);
            panel1.Name = "panel1" + no;
            panel1.Size = new System.Drawing.Size(809, 38);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(569, 6);
            label4.Name = "label4" + no;
            label4.Size = new System.Drawing.Size(173, 12);
            label4.TabIndex = 8 + no;
            label4.Text = "按天调度只需设置周日的时间段";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(498, 4);
            radioButton2.Name = "radioButton2" + no;
            radioButton2.Size = new System.Drawing.Size(47, 16);
            radioButton2.TabIndex = 7 + no;
            radioButton2.TabStop = true;
            radioButton2.Text = "按周";
            radioButton2.UseVisualStyleBackColor = true;
            rb_mode[no,1] = radioButton2;
            
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(445, 3);
            radioButton1.Name = "radioButton1" + no;
            radioButton1.Size = new System.Drawing.Size(47, 16);
            radioButton1.TabIndex = 6 + no;
            radioButton1.TabStop = true;
            radioButton1.Text = "按天";
            radioButton1.UseVisualStyleBackColor = true;
            rb_mode[no, 0] = radioButton1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(380, 4);
            label3.Name = "label3" + no;
            label3.Size = new System.Drawing.Size(59, 12);
            label3.TabIndex = 5 + no;
            label3.Text = "调度方式:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(263, 1);
            textBox2.Name = "textBox2" + no;
            textBox2.Size = new System.Drawing.Size(100, 21);
            textBox2.TabIndex = 4 + no;
            txt_name[no] = textBox2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(228, 4);
            label2.Name = "label2" + no;
            label2.Size = new System.Drawing.Size(29, 12);
            label2.TabIndex = 3 + no;
            label2.Text = "名称";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(165, 1);
            textBox1.Name = "textBox1" + no;
            textBox1.Size = new System.Drawing.Size(57, 21);
            textBox1.TabIndex = 2 + no;
            txt_no[no] = textBox1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(130, 4);
            label1.Name = "label1" + no;
            label1.Size = new System.Drawing.Size(29, 12);
            label1.TabIndex = 1 + no;
            label1.Text = "编号";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            checkbox1.AutoSize = true;
            checkbox1.Location = new System.Drawing.Point(76, 3);
            checkbox1.Name = "checkBox1" + no;
            checkbox1.Size = new System.Drawing.Size(48, 16);
            checkbox1.TabIndex = 0;
            checkbox1.Text = "启用";
            checkbox1.UseVisualStyleBackColor = true;
            chk_enable_group[no] = checkbox1;


            return tabPage1;

        }
        private System.Windows.Forms.TabPage createEffectAreaElement(int yno, int xno, string week) {
            System.Windows.Forms.TabPage tabPage2 = new System.Windows.Forms.TabPage();
            System.Windows.Forms.Panel panel2 = new System.Windows.Forms.Panel();
          
            // 
            // tabPage2
            // 
           tabPage2.Controls.Add(panel2);
           tabPage2.Location = new System.Drawing.Point(4, 22);
           tabPage2.Name = "tabPage2"+yno+""+xno;
           tabPage2.Padding = new System.Windows.Forms.Padding(3);
           tabPage2.Size = new System.Drawing.Size(795, 398);
           tabPage2.TabIndex = 0;
           tabPage2.Text = week;
           tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
          
          
           panel2.Dock = System.Windows.Forms.DockStyle.Top;
           panel2.Location = new System.Drawing.Point(3, 3);
           panel2.Name = "panel2"+yno;
           panel2.Size = new System.Drawing.Size(789, 392);
           panel2.TabIndex = 6;

           for (int i = 0; i < 6; i++)
           {
               // 
               // panel3
               // 
               System.Windows.Forms.Panel panel3 = new System.Windows.Forms.Panel();
               panel3.Dock = System.Windows.Forms.DockStyle.Top;
               panel3.Location = new System.Drawing.Point(0, 60);
               panel3.Name = "panel3" + xno+i;
               panel3.Size = new System.Drawing.Size(789, 60);
               panel3.TabIndex = 7;
               panel2.Controls.Add(panel3);
               // 
               // textBox5
               // 
               System.Windows.Forms.TextBox textBox5 = new System.Windows.Forms.TextBox();
               textBox5.Location = new System.Drawing.Point(488, 18);
               textBox5.Name = "textBox5" + xno+i;
               textBox5.Size = new System.Drawing.Size(100, 21);
               textBox5.TabIndex = 10;
               txt_hour_end[yno, i, xno] = textBox5;
               // 
               // textBox6
               // 
               System.Windows.Forms.TextBox textBox6 = new System.Windows.Forms.TextBox();
               textBox6.Location = new System.Drawing.Point(607, 18);
               textBox6.Name = "textBox6" + xno+i;
               textBox6.Size = new System.Drawing.Size(100, 21);
               textBox6.TabIndex = 11;

               txt_minute_end[yno, i, xno] = textBox6;
               // 
               // checkBox2
               // 
               System.Windows.Forms.CheckBox checkBox2 = new System.Windows.Forms.CheckBox();
               checkBox2.AutoSize = true;
               checkBox2.Location = new System.Drawing.Point(77, 23);
               checkBox2.Name = "checkBox2" + xno+i;
               checkBox2.Size = new System.Drawing.Size(48, 16);
               checkBox2.TabIndex = 6;
               checkBox2.Text = "启用";
               checkBox2.UseVisualStyleBackColor = true;
               chk_enable_segment[yno, xno, i] = checkBox2;

               // 
               // label5
               // 
               System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
               label5.AutoSize = true;
               label5.Location = new System.Drawing.Point(162, 24);
               label5.Name = "label5" + xno+i;
               label5.Size = new System.Drawing.Size(53, 12);
               label5.TabIndex = 7;
               label5.Text = "时间区间";
               // 
               // textBox4
               // 
               System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
               textBox4.Location = new System.Drawing.Point(347, 18);
               textBox4.Name = "textBox4" + xno+i;
               textBox4.Size = new System.Drawing.Size(100, 21);
               textBox4.TabIndex = 9;
               txt_minute_start[yno, i, xno] = textBox4;
               // 
               // textBox3
               // 
               System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
               textBox3.Location = new System.Drawing.Point(239, 18);
               textBox3.Name = "textBox3" + xno+i;
               textBox3.Size = new System.Drawing.Size(100, 21);
               textBox3.TabIndex = 8;
               txt_hour_start[yno, i, xno] = textBox3;

               // 
               // panel4
               // 
               panel3.Controls.Add(textBox5);
               panel3.Controls.Add(textBox6);
               panel3.Controls.Add(checkBox2);
               panel3.Controls.Add(label5);
               panel3.Controls.Add(textBox4);
               panel3.Controls.Add(textBox3);
           }


           return tabPage2;
        
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