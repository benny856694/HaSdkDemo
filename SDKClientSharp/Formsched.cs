using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaSdkWrapper;

namespace SDKClientSharp
{
    public partial class Formsched : Form
    {
        private HaCamera _cam;
        public Formsched()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.tabControl1.Controls.Add(this.createEffectArea(0, "规则1"));
            this.tabControl1.Controls.Add(this.createEffectArea(1, "规则2"));
            this.tabControl1.Controls.Add(this.createEffectArea(2, "规则3"));
            this.tabControl1.Controls.Add(this.createEffectArea(3, "规则4"));
            this.tabControl1.Controls.Add(this.createEffectArea(4, "规则5"));

        }

        public Formsched(HaCamera _cam) : this()
        {
            this._cam = _cam;
            KindSchedule[] kin = _cam.GetScheduleModeCfg();
            for (int i = 0; i < kin.Length; i++)
            {
                KindSchedule ki = kin[i];
                txt_no[i].Text = ki.ScheduleNameCode + "";
                txt_name[i].Text = Encoding.Default.GetString(Converter.ConvertStringToDefault(ki.ScheduleName));
                chk_enable_group[i].Checked = true;
                if (ki.Mode == ScheduleMode.SCHEDULE_MODE_DAILY)
                {
                    rb_mode[i, 0].Checked = true;
                    DailySchedule[] daily = ki.Schedule;
                    for (int j = 0; j < daily[0].Sector; j++)
                    {
                        HourSchedule hours = daily[0].SchTime[j];
                        txt_hour_start[i, j, 0].Text = hours.start.hour + "";
                        txt_minute_start[i, j, 0].Text = hours.start.minute + "";
                        txt_hour_end[i, j, 0].Text = hours.end.hour + "";
                        txt_minute_end[i, j, 0].Text = hours.end.minute + "";
                        chk_enable_segment[i, 0, j].Checked = true;


                    }


                }
                else if (ki.Mode == ScheduleMode.SCHEDULE_MODE_WEEKLY)
                {

                    rb_mode[i, 1].Checked = true;
                    for (int j = 0; j < ki.Schedule.Length; j++) {
                        for (int s = 0; s < ki.Schedule[j].Sector; s++) {
                            HourSchedule hours = ki.Schedule[j].SchTime[s];
                            txt_hour_start[i, s, j].Text = hours.start.hour + "";
                            txt_minute_start[i, s, j].Text = hours.start.minute + "";
                            txt_hour_end[i, s, j].Text = hours.end.hour + "";
                            txt_minute_end[i, s, j].Text = hours.end.minute + "";
                            chk_enable_segment[i, j, s].Checked = true;
                        
                        
                        }

                    
                    
                    }


                }




            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.txt_no[1].Text = "dfsa";

           // Console.Write(chk_enable_group[0].Checked+"dsa");
            //Console.Write(chk_enable_group[1].Checked);
            //Console.Write(chk_enable_group[2].Checked);
            //计算启用了多少规则
            int kindlen = 0;
            for (int i = 0; i < chk_enable_group.Length; i++) {
                if (chk_enable_group[i].Checked) {
                    kindlen++;
                }
            
            
            }


            KindSchedule[] kind = new KindSchedule[kindlen];
            int k = 0;
            for (int i = 0; i < 5; i++) {
                if (chk_enable_group[i].Checked) {
                    kind[k].ScheduleNameCode =Convert.ToUInt16( txt_no[i].Text);
                    byte[] idStrBytes = Encoding.UTF8.GetBytes(txt_name[i].Text);
                      byte[] name  = new byte[16];
                     Array.Copy(idStrBytes, name, Math.Min(idStrBytes.Length, 20));

                     kind[k].ScheduleName = name;

                     if (rb_mode[i, 0].Checked)
                     {
                         kind[k].Mode = ScheduleMode.SCHEDULE_MODE_DAILY;

                     }
                     else {
                         kind[k].Mode = ScheduleMode.SCHEDULE_MODE_WEEKLY;
                     
                     }
                     DailySchedule[] dail = new DailySchedule[7];
                    for(int j=0;j<7;j++){
                        
                        int Sector = 0;
                        HourSchedule[] ho = new HourSchedule[6];
                        for (int y = 0; y < 6; y++) { 
                        if(chk_enable_segment[i,j,y].Checked){
                            
                            MinuteSchedule start = new MinuteSchedule();

                            start.hour = Convert.ToByte(txt_hour_start[i, y, j].Text);
                            start.minute = Convert.ToByte(txt_minute_start[i, y, j].Text);
                            ho[y].start.hour = start.hour;
                            ho[y].start.minute = start.minute;

                            start.hour = Convert.ToByte(txt_hour_end[i, y, j].Text);
                            start.minute = Convert.ToByte(txt_minute_end[i, y, j].Text);
                            ho[y].end.hour = start.hour;
                            ho[y].end.minute = start.minute;

                            Sector++;
                             dail[j].Sector  = Convert.ToUInt32(Sector);

                            dail[j].SchTime = ho;
                            kind[k].Schedule = dail;
                        }


                        }






                            if (kind[k].Mode == ScheduleMode.SCHEDULE_MODE_DAILY)
                            {
                                break;
                            }


                    
                    }




                    k++;
                
                
                
                }


                
            
            
            
            
            
            }



            _cam.SetScheduleModeCfg(kind);


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
            tabControl2.Controls.Add(createEffectAreaElement(no, 0, "周日"));
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
            rb_mode[no, 1] = radioButton2;

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
        private System.Windows.Forms.TabPage createEffectAreaElement(int yno, int xno, string week)
        {
            System.Windows.Forms.TabPage tabPage2 = new System.Windows.Forms.TabPage();
            System.Windows.Forms.Panel panel2 = new System.Windows.Forms.Panel();

            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2" + yno + "" + xno;
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
            panel2.Name = "panel2" + yno;
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
                panel3.Name = "panel3" + xno + i;
                panel3.Size = new System.Drawing.Size(789, 60);
                panel3.TabIndex = 7;
                panel2.Controls.Add(panel3);
                // 
                // textBox5
                // 
                System.Windows.Forms.TextBox textBox5 = new System.Windows.Forms.TextBox();
                textBox5.Location = new System.Drawing.Point(488, 18);
                textBox5.Name = "textBox5" + xno + i;
                textBox5.Size = new System.Drawing.Size(100, 21);
                textBox5.TabIndex = 10;
                txt_hour_end[yno, i, xno] = textBox5;
                // 
                // textBox6
                // 
                System.Windows.Forms.TextBox textBox6 = new System.Windows.Forms.TextBox();
                textBox6.Location = new System.Drawing.Point(607, 18);
                textBox6.Name = "textBox6" + xno + i;
                textBox6.Size = new System.Drawing.Size(100, 21);
                textBox6.TabIndex = 11;

                txt_minute_end[yno, i, xno] = textBox6;
                // 
                // checkBox2
                // 
                System.Windows.Forms.CheckBox checkBox2 = new System.Windows.Forms.CheckBox();
                checkBox2.AutoSize = true;
                checkBox2.Location = new System.Drawing.Point(77, 23);
                checkBox2.Name = "checkBox2" + xno + i;
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
                label5.Name = "label5" + xno + i;
                label5.Size = new System.Drawing.Size(53, 12);
                label5.TabIndex = 7;
                label5.Text = "时间区间";
                // 
                // textBox4
                // 
                System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
                textBox4.Location = new System.Drawing.Point(347, 18);
                textBox4.Name = "textBox4" + xno + i;
                textBox4.Size = new System.Drawing.Size(100, 21);
                textBox4.TabIndex = 9;
                txt_minute_start[yno, i, xno] = textBox4;
                // 
                // textBox3
                // 
                System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
                textBox3.Location = new System.Drawing.Point(239, 18);
                textBox3.Name = "textBox3" + xno + i;
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

        private void Formsched_Load(object sender, EventArgs e)
        {

        }
    }
}
