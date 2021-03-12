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
        }
        public Formsched(HaCamera _cam)
        {
            InitializeComponent();
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
    }
}
